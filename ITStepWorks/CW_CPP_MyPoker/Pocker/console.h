#pragma once
#include <iostream>
#include <Windows.h>
#include <conio.h>
#include <vector>
#include <string>
#include <iterator>
#include <map>

#include "grfx.h"

#define VK_UP		72
#define VK_DOWN		80
#define VK_LEFT		75
#define VK_RIGHT	77

#define VK_1		49
#define VK_2		50
#define VK_3		51
#define VK_4		52
#define VK_5		53


#define P_CARD1_PC		10,3
#define P_CARD2_PC		18,3
#define P_CARD3_PC		26,3
#define P_CARD4_PC		34,3
#define P_CARD5_PC		42,3

#define P_CARD1_PLAY	10,18
#define P_CARD2_PLAY	18,18
#define P_CARD3_PLAY	26,18
#define P_CARD4_PLAY	34,18
#define P_CARD5_PLAY	42,18

#define P_NAME_PC		60,3
#define P_NAME_PLAY		60,18

#define P_MONEY_PC		61,4
#define P_MONEY_PLAY	61,19

#define P_COMB_PC		54,6
#define P_COMB_PLAY		54,21

#define CARD_DISTANCE	8

#define MAP_PLAYER		{P_CARD1_PLAY}, {P_NAME_PLAY}, {P_MONEY_PLAY}, {P_COMB_PLAY}
#define MAP_PC			{P_CARD1_PC}, {P_NAME_PC}, {P_MONEY_PC}, {P_COMB_PC}
					//0,1 - Координаты первой карты [x],[y]
					//2,3 - Координаты Имени игрока [x],[y]
					//4,5 - Координаты Баланса  [x],[y]
					//6,7 - Координаты Выигрышной комбинации [x],[y]

#define COORD_MESSAGE	5,9
#define MAX_MSG_LENGHT	55

#define COORD_CASH		17,12



using namespace std;

namespace console {

	enum cColor
	{
		Black = 0,
		Blue = 1,
		Green = 2,
		Cyan = 3,
		Red = 4,
		Magenta = 5,
		Brown = 6,
		LightGray = 7,
		DarkGray = 8,
		LightBlue = 9,
		LightGreen = 10,
		LightCyan = 11,
		LightRed = 12,
		LightMagenta = 13,
		Yellow = 14,
		White = 15
	};

	enum class message { getDeal_msg, getBet_msg, flipCards, pIsWin, pcIsWin, deadHeat, endCards};

	struct Messages {
		const vector<string> m_lpMenuItem;
		const vector<string> m_lpMessages;
		const vector<string> m_lpCombStr;
		Messages():m_lpMenuItem{ "   NEW GAME   ", "   RAITINGS   ", "     INFO     ", "     EXIT     " },
			m_lpMessages{"Press 'Enter' to Deal and 'Esc' for exit", "Get your bets! Push UP and DOWN button. ENTER if end.", "button 1 - 5 to hold need cadr. ENTER next.", "Player is WIN!!!", "PC is WIN!!!", "Dead heat!!!", "GAME END! No more cards!" },
			m_lpCombStr{ "","Hight Card", "One Pair", "Two Pairs", "Set", "Streath", "Flush", "Full House", "Four of a King", "Streight Flush", "Royal Flush" } {}
	};

	class ConsoleOut : public Messages
	{
		HANDLE hStdOut;
		HWND hwnd;
	public:
		const COORD m_COORD_card1;	//пара координаты первой карты игрока
		const COORD m_COORD_name;	//пара координаты начала имени игрока
		const COORD m_COORD_money;	//пара координаты начала цифры кошелька игрока
		const COORD m_COORD_comRes;	//пара координаты начала подписи выигрышной комбинации 

	protected:
		void gotoxy(COORD);

		void setColor(int cText, int cBackground);

		void hideCursor();

		void initSetup();

		void clearLine(COORD pos, size_t lenght);

	public:
		ConsoleOut(COORD crd = { 0 }, COORD name = { 0 }, COORD money = { 0 }, COORD comb = { 0 });
		//////////Рисует меню выбора
		void fillMainMenu(int pos);
		//////////Рисует канву рейтинга (Без вывода самого рейтинга)
		void fillRaitings(vector<string>& str);
		//////////Рисует канву ИНФО
		void fillInfo();
		//////////Рисует канву основной игры
		void fillMainGame();
		//////////Выводит сумму ставок
		void displayCash(int cash);
		//////////Очищает поле карты
		void clearCard(COORD pos);
		//////////Очищает поля всех карт
		void clearAllCards();
		//////////Отрисовка обратной стороны карты
		void fillCardBack(COORD pos);
		//////////Отрисовка отратной стороны всех карт
		void fillCardsBack();
		//////////Вывод информационного сообщения
		void displayMessage(message msgIndex);
		//////////Движение по меню и возврат выбраной позиции
		short mainMenu();
		//////////Отрисовует красным цветом цифры под картами которые менять не желательно
		void remarkIndexCards(vector<size_t>& _i);

	};

}