#include <iostream>
#include <Windows.h>
#include <conio.h>


#include "MainFunct.h"
#include "Player.h"
#include "Storage.h"

HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
HWND hwnd = GetConsoleWindow();

void gotoxy(short x, short y)
{
	COORD  coord = { x, y };
	SetConsoleCursorPosition(hStdOut, coord);
}

void SetColor(int cText, int cBackground) // ãáâ ­ ¢«¨¢ ¥¬ æ¢¥â
{
	SetConsoleTextAttribute(hStdOut, (WORD)((cBackground << 4) | cText));
}

void HideCursor() {
	CONSOLE_CURSOR_INFO structCursorInfo;
	GetConsoleCursorInfo(hStdOut, &structCursorInfo);
	structCursorInfo.bVisible = FALSE;
	SetConsoleCursorInfo(hStdOut, &structCursorInfo);
}

void setup() {
	system("mode con cols=80 lines=25");
	SetConsoleTitle("TRON Game");
	HideCursor();
	system("cls");
}

void FillMainMenu(int pos) {
	SetColor(White, Black);

	for (int i = 0; i < (sizeof(st_menu_item)/(sizeof(char)*14)); i++) {
		gotoxy(33, 18 + i);
		if (pos == i) SetColor(Black, White);
		else SetColor(White, Black);
		std::cout << st_menu_item[i];

	}
}

short MainMenu() {
	short menuIndex = 0;
	bool menu_on = true;
	SetColor(White, Black);
	std::cout << MAIN_MENU_MAP;
	FillMainMenu(menuIndex);
	while (menu_on) {
		if (_kbhit()) {
			switch (_getch()) {
			case VK_UP: if (--menuIndex < 0) menuIndex = 3; break;
			case VK_DOWN: if (++menuIndex > 3) menuIndex = 0; break;
			case VK_RETURN: menu_on = false; return menuIndex;
			default: break;

			}
			FillMainMenu(menuIndex);
		}
	}
}

void EnterNames(MOTO &obj, MOTO &obj2) {
	system("cls");
	SetColor(White, Black);
	std::cout << MAIN_MENU_MAP;
	gotoxy(30, 18);
	std::cout << "Player 1 name: ";
	std::getline(std::cin, obj.name);
	gotoxy(30, 20);
	std::cout << "Player 2 name: ";
	std::getline(std::cin, obj2.name);
}

void FillInfo() {
	system("cls");
	SetColor(White, Black);
	std::cout << INFO_MAP;
	while (true) {
		if (!_kbhit()) {
			if (_getch() == VK_ESCAPE) return;
		}
	}
}

void ViewStat() {
	const int n_line = NUM_LINE;
	string stat[n_line];
	string* p_stat = stat;
	int size = 0;
	ReadStat(p_stat);
	system("cls");
	SetColor(White, Black);
	cout << INFO_STAT_MAP;


	/* âûâîäèì ýëåìåíòû â ïîðÿäêå ÷òåíèÿ */
	gotoxy(20, 9);
	std::cout << "Name : Score";
	for (int i = 0; i < n_line; i++) {
		gotoxy(20, 11+i);
		std::cout << stat[i] << endl;
	}
}

void GraphCanvas() {
	system("cls");
	SetColor(White, Black);
	std::cout << CANVAS_MAP;
}


bool fild_out(struct MOTO &obj) {
	if (obj.curpos.x <= X_MIN || obj.curpos.x >= X_MAX || obj.curpos.y <= Y_MIN || obj.curpos.y >= Y_MAX) {
		obj.loss = true;
		return 1;
	}
	else return 0;
}

bool find_tail(POINT* tail, int n, struct MOTO &obj) {
	for (int i = 0; i < n; i++){
		if (tail[i].x == obj.curpos.x && tail[i].y == obj.curpos.y) { 
			obj.loss = true;
			return 1;
		}
	}
	return 0;
}

