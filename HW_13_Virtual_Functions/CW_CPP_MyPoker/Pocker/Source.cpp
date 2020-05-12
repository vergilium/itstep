#include <iostream>
#include <io.h>
#include <fcntl.h>
#include <Windows.h>
#include <array>
#include <iterator>

#include "card.h"
#include "console.h"
#include "grfx.h"
#include "player.h"
#include "storage.h"
#include "smart.h"

using namespace std;


enum menu { newGame, raitings, info, m_exit };

/////////////////////////////////////////////////////////////////
enum class game { noGame = -1, start, deal, bill, flipCard, nextDeal, waitAction, openCards, getWinners, gameEnd, endCDesk};

game& operator++ (game& g) {
	g = static_cast<game>(static_cast<int>(g) + 1);
	return g;
}

game operator++ (game& g, int) {
	game old = g;
	g = static_cast<game>(static_cast<int>(g) + 1);
	return old;
}

game& operator-- (game& g) {
	g = static_cast<game>(static_cast<int>(g) - 1);
	return g;
}

game operator-- (game& g, int) {
	game old = g;
	g = static_cast<game>(static_cast<int>(g) - 1);
	return old;
}
/////////////////////////////////////////////////////////////////
////Обработка фиксации карты
bool holdCard(array<int, 2>& arr, int index) {
	auto iter = find(arr.begin(), arr.end(), index);
	if (iter != arr.end()) {
		*iter = -1;
		return false;
	}
	else {
		iter = find(arr.begin(), arr.end(), -1);
		if (iter != arr.end()) {
			*iter = index;
			return true;
		}
		else return false;
	}
}


int main() {
	_setmode(_fileno(stdout), _O_U16TEXT);
	_setmode(_fileno(stdin), _O_U16TEXT);
	
	uint8_t menuIndex = 0;
	game game_status = game::noGame;
	int cash = 0;

	console::ConsoleOut cOut;
	cardstd::CardsDesk cDesk;
	playerstd::Player player(MAP_PLAYER);
	playerstd::Player pc(MAP_PC, "PC");
	smartstd::Smart smtAction;
	array<int,2> pcHold = {-1,-1};
	array<int,2> playerHolds = {-1,-1};
	storstd::Storage db("statistics.db");
	vector<size_t> _sCds;
	
	////////////////////////////////////////////////////////////////
start:	//////////////////////////////////ЗАПУСК ИГРОВОГО ПРОЦЕССА//
	////////////////////////////////////////ВЫВОД ОСНОВНОГО МЕНЮ////
	system("cls");
	wcout << MAIN_MENU_SCREEN;
	menuIndex = cOut.mainMenu();
	
	switch (menuIndex) {			///Переключатель этапов игры
	case menu::newGame:
		cOut.fillMainGame();		///Вывод графики основного экрана игры
	
		game_status = game::start;
		for (;;) {
			player.fillPlayerData();
			pc.fillPlayerData();
			cash = player.getBet() + pc.getBet();
			cOut.displayCash(cash);

			switch (game_status) {
				//////////////////////////////////////START GAME////////////////////////////
			case game::start:
				player.clearAllCards();
				pc.clearAllCards();
				cOut.displayMessage(console::message::getDeal_msg);
				break;
				//////////////////////////////////////  DEAL  //////////////////////////////
			case game::deal:
				////////////////////Перетасовка колоды
				cDesk.shuffle();
				////////////////////Раздача карт с проверкой на пустую колоду
				if (!player.getDeal(cDesk) || !pc.getDeal(cDesk)) {
					game_status = game::endCDesk;
					break;
				}
				//////////////////Сортировка комбинации карт
				player.sortComb();
				pc.sortComb();
				//////////////////Вывод комбинации карт на экран
				cOut.fillCardsBack();
				player.displayCombination();
				//////////////////Определение СИЛЫ комбинации
				player.findCombinations();
				pc.findCombinations();
				//////////////////Вывод результата силы комбинации	(для игрока)
				player.dispResult();

				cOut.displayMessage(console::message::getBet_msg);
				game_status++;	///Следующий этап игры
				break;
				////////////////////////////////////// FLIP CARD ////////////////////////////
			case game::flipCard:
				//////////////////Выводится сообщение о возможности замены карт
				//////////////////И в обработчике кнопок активируется возможность поменять до 2х карт
				cOut.displayMessage(console::message::flipCards);
				_sCds = player.getSingleCards();
				cOut.remarkIndexCards(_sCds);
				break;
				////////////////////////////////////// NEXT DEAL ////////////////////////////
			case game::nextDeal:
				//////////////////Фиксация выбраных карт для замены и новая раздача с колоды
				if (playerHolds[0] != -1) player.getNewCard(cDesk, playerHolds[0]);
				if (playerHolds[1] != -1) player.getNewCard(cDesk, playerHolds[1]);

				if (smtAction.getholdCards()[0] != -1) pc.getNewCard(cDesk, smtAction.getholdCards()[0]);
				if (smtAction.getholdCards()[1] != -1) pc.getNewCard(cDesk, smtAction.getholdCards()[1]);
				//////////////////Вывод новых карт
				player.displayCombination();
				//////////////////Повторное определение СИЛЫ комбинации
				player.findCombinations();
				pc.findCombinations();
				//////////////////Вывод результата СИЛЫ
				player.dispResult();
				game_status++;///След. этап игры
				break;
				//////////////////////////////////////WAIT ACTION////////////////////////////
			case game::waitAction:
				break;//////Ожидание выбора действия по игре
				//////////////////////////////////////OPEN CARDS////////////////////////////
			case game::openCards:
				////////////////////////////////Вскрытие карт//////
				pc.displayCombination();
				pc.dispResult();
				break;
				//////////////////////////////////////GET WINERS////////////////////////////
			case game::getWinners:
				////////////////////////////ОПРЕДЕЛЕНИЕ ПОБЕДИТЕЛЯ//////////////////////////
				if (player.getResult() > pc.getResult()) {
					player.isWiner();
					cOut.displayMessage(console::message::pIsWin);
					player.takeWin(cash);
					pc.resetBet();
					cash = 0;
				}
				else if (player.getResult() < pc.getResult()) {
					pc.isWiner();
					pc.isWiner();
					cOut.displayMessage(console::message::pcIsWin);
					pc.takeWin(cash);
					player.resetBet();
					cash = 0;
				}
				else{
					cOut.displayMessage(console::message::deadHeat);
					player.takeWin(player.getBet());
					pc.takeWin(pc.getBet());
				}
				break;
				////////////ЕСЛИ КОЛОДА ПУСТА, Конец игры
			case game::endCDesk:
				cOut.displayMessage(console::message::endCards);
				if (player.getMoney() > pc.getMoney()) {
					db.newRecord(player.getName(), player.getMoney());
				}
				Sleep(5000);
				exit(0);
				break;
				//////////////////////////////////////GAME END////////////////////////////
			case game::gameEnd:
				player.resetComb();
				pc.resetComb();
				playerHolds.fill(-1);
				pcHold.fill(-1);

				player.clearPlayerData();
				pc.clearPlayerData();
				break;
			default: game_status = game::start; break;
			}
			/////////////////////////////////////KEYBORD HANDLER//////////////////////////
			if (_kbhit) {
				//wcout << _getch();
				switch (_getch()) {
				case VK_RETURN:								//KEY ENTER
					if (game_status != game::endCDesk) {
						if (game_status == game::gameEnd)
							game_status = game::start;
						else ++game_status;
						if (game_status == game::flipCard) {
							smtAction.smrtAction(pc.getResult().first, pc.getSingleCards(), player.getBet());
							pc.popMoney(player.getBet() * smtAction.getAction());
						}
					}
					break;
				case VK_ESCAPE: goto start;					//KEY ESCAPE, GAME EXIT
				case VK_UP:									//KEY UP, BET +
					if (game_status == game::bill) {
						player.popMoney(1);
					}
					break;
				case VK_DOWN:								//KEY DOWN, BET -
					if (game_status == game::bill) {
						player.pushMoney(1);
					}
					break;
				case VK_1:if (game_status == game::flipCard) {	//KEY 1, HOLD CARD 1
					if (holdCard(playerHolds, 0)) {
						cOut.fillCardBack({ P_CARD1_PLAY });
					}
					else {
						cOut.clearCard({ P_CARD1_PLAY });
						player.fillCardFace(0);
					}
				}
						break;
				case VK_2:if (game_status == game::flipCard) {	//KEY 2, HOLD CARD 2
					if (holdCard(playerHolds, 1)) {
						cOut.fillCardBack({ P_CARD2_PLAY });
					}
					else {
						cOut.clearCard({ P_CARD2_PLAY });
						player.fillCardFace(1);
					}
				}
					break;
				case VK_3:if (game_status == game::flipCard) {	//KEY 3, HOLD CARD 3
					if (holdCard(playerHolds, 2)) {
						cOut.fillCardBack({ P_CARD3_PLAY });
					}
					else {
						cOut.clearCard({ P_CARD3_PLAY });
						player.fillCardFace(2);
					}
				}
					break;
				case VK_4:if (game_status == game::flipCard) {	//KEY 4, HOLD CARD 4
					if (holdCard(playerHolds, 3)) {
						cOut.fillCardBack({ P_CARD4_PLAY });
					}
					else {
						cOut.clearCard({ P_CARD4_PLAY });
						player.fillCardFace(3);
					}
				}
					break;
				case VK_5:if (game_status == game::flipCard) {	//KEY 5, HOLD CARD 5
					if (holdCard(playerHolds, 4)) {
						cOut.fillCardBack({ P_CARD5_PLAY });
					}
					else {
						cOut.clearCard({ P_CARD5_PLAY });
						player.fillCardFace(4);
					}
				}
					break;
				default:break;
					
				}
				Sleep(10);
			}
		}
		break;
	case menu::raitings: cOut.fillRaitings(db.getRecords());
							while (true) {
								if (!_kbhit()) { if (_getch() == VK_ESCAPE) break; }
								}
							break;
	case menu::info: cOut.fillInfo(); break;
	case menu::m_exit: std::exit(0); break;
	}
	goto start;
	
	return 0;
} 