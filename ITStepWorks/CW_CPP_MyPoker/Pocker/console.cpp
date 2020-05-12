#include "console.h"

using namespace console;

ConsoleOut::ConsoleOut(COORD crd, COORD name, COORD money, COORD comb): m_COORD_card1(crd), m_COORD_name(name), m_COORD_money(money), m_COORD_comRes(comb)
{
	hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	hwnd = GetConsoleWindow();
	initSetup();
}

void ConsoleOut::gotoxy(COORD pos) {
	COORD  coord = pos;
	SetConsoleCursorPosition(hStdOut, coord);
}

void ConsoleOut::setColor(int cText, int cBackground) {
	SetConsoleTextAttribute(hStdOut, (WORD)((cBackground << 4) | cText));
}

void ConsoleOut::hideCursor() {
	CONSOLE_CURSOR_INFO structCursorInfo;
	GetConsoleCursorInfo(hStdOut, &structCursorInfo);
	structCursorInfo.bVisible = FALSE;
	SetConsoleCursorInfo(hStdOut, &structCursorInfo);
}

void ConsoleOut::initSetup() {
	system("mode con cols=80 lines=25");
	SetConsoleTitle(L"-=MyPoker=-");
	hideCursor();
	system("cls");
	setColor(White, Black);
}

void ConsoleOut::clearLine(COORD pos, size_t lenght) {
	gotoxy(pos);
	wcout.write(L"                                                       ", lenght);
}

void ConsoleOut::fillMainMenu(int pos) {
	setColor(White, Black);
	for (auto iter = m_lpMenuItem.begin(); iter != m_lpMenuItem.end(); ++iter) {
		gotoxy({ 33, 18 + (short)distance(m_lpMenuItem.begin() , iter) });
		if (pos == distance(m_lpMenuItem.begin(), iter)) setColor(Black, White);
		else setColor(White, Black);
		wcout << iter->c_str();
	}

}

void ConsoleOut::fillRaitings(vector<string>& str) {
	system("cls");
	wcout << RAITING_SCREEN;
	short i = 0;
	for (auto iter = str.begin(); iter != str.end(); ++iter) {
		gotoxy({ 25,11 + (i++) });
		wcout << iter->c_str() << " ---------------------- ";
		++iter;
		wcout << iter->c_str();
	}
}

void ConsoleOut::fillInfo() {
	system("cls");
	wcout << INFO_SCREEN;
	while (true) {
		if (!_kbhit()) {
			if (_getch() == VK_ESCAPE) break;
		}
	}
}

void ConsoleOut::fillMainGame() {
	system("cls");
	wcout << MAIN_GAME_SCREEN;
}

void ConsoleOut::displayCash(int cash) {
	clearLine({ COORD_CASH }, 5);
	gotoxy({ COORD_CASH });
	wcout << cash << " $";
}

void ConsoleOut::fillCardBack(COORD pos) {
	for (int i = 0; i < 4; ++i) {
		gotoxy(pos);
		wcout << L"░░░░░░";
		pos.Y++;
	}
}

void ConsoleOut::clearCard(COORD pos) {
	for (int i = 0; i < 4; ++i) {
		clearLine(pos, 6);
		pos.Y++;
	}
}

void ConsoleOut::clearAllCards() {
	short card_distance = 0;
	for (size_t i = 0; i < 5; ++i, card_distance += CARD_DISTANCE) {
		clearCard({m_COORD_card1.X + card_distance, m_COORD_card1.Y });
	}
}

void ConsoleOut::fillCardsBack() {
	for (short i = 10; i <= 42; i += 8) {
		fillCardBack({ i, 3 });
	}
}

void ConsoleOut::displayMessage(message msgIndex) {
	clearLine({ COORD_MESSAGE }, MAX_MSG_LENGHT);
	gotoxy({ COORD_MESSAGE });
	wcout << console::Messages::m_lpMessages.at((size_t)msgIndex).c_str();
}

short ConsoleOut::mainMenu() {
	short menuIndex = 0;
	bool menu_on = true;
	fillMainMenu(menuIndex);
	while (menu_on) {
		if (_kbhit()) {
			switch (_getch()) {
			case VK_UP: if (--menuIndex < 0) menuIndex = 3; break;
			case VK_DOWN: if (++menuIndex > 3) menuIndex = 0; break;
			case VK_RETURN: menu_on = false; return menuIndex;
			default: break;

			}
			fillMainMenu(menuIndex);
		}
	}
}

void ConsoleOut::remarkIndexCards(vector<size_t>& _i) {
	for (short i = 0; i < 5; ++i) {
		gotoxy({ 12 + (i * 8),23 });
		if (find(_i.begin(), _i.end(), i) != _i.end()) {
			setColor(White, Black);
		}
		else setColor(Red, Black);
		wcout << i + 1;
	}
	setColor(White, Black);
}