#pragma once

#include <iostream>
#include <Windows.h>

#include "Maps.h"

#define VK_UP		72
#define VK_DOWN		80
#define VK_LEFT		75
#define VK_RIGHT	77

#define VK_W		119
#define VK_S		115
#define VK_A		100
#define VK_D		97

#define X_MIN		0
#define X_MAX		69
#define Y_MIN		0
#define Y_MAX		24

#define P_RAND(min,max) (rand()%((max - min) + 1) + min)


const char st_menu_item[][14] = { " €—€’œ ˆƒ“ ", "   …‰’ˆƒ   ", "    ˆ”     ", "    ‚›•„    " };


enum ConsoleColor
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

void setup(void);
void gotoxy(short, short);
void SetColor(int, int);
void HideCursor(void);
void FillMainMenu(int);
short MainMenu(void);
void EnterNames(struct MOTO &, struct MOTO &);
void FillInfo(void);
void ViewStat(void);
void GraphCanvas(void);
bool fild_out(struct MOTO &);
bool find_tail(POINT*, int, struct MOTO &);

