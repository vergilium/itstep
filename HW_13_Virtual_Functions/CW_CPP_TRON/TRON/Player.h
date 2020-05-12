#pragma once
#include <string>

#include "MainFunct.h"

using namespace std;

enum CH_DIR {
	TtoR = 'É', TtoL = '»', BtoR = 'È', BtoL = '¼', LtoT = 'È', LtoB = 'É', RtoT = '¼', RtoB = '»'
};

struct MOTO {
	short color;
	char direction;
	char ch_dir;
	bool loss = false;
	POINT curpos;
	POINT lastpos;
	POINT *tail = nullptr;
	string name;

	void init(short col, char dir, POINT cpos) {
		POINT* p_tail = new POINT[1];
		color = col;
		direction = dir;
		ch_dir = 'Í';
		curpos = cpos;
		if(tail == nullptr)
			tail = p_tail;
		delete[]p_tail;
	}

	void move() {
		SetColor(color, Black);
		switch (direction) {
		case 'T': 
			gotoxy(curpos.x, curpos.y);
			if (ch_dir) {cout << ch_dir; ch_dir = 0;}
			else cout << "º";
			lastpos = curpos;
			curpos.y--;
			gotoxy(curpos.x, curpos.y);
			cout << "#";
			break;
		case 'B': 
			gotoxy(curpos.x, curpos.y);
			if (ch_dir) { cout << ch_dir; ch_dir = 0; }
			else cout << "º";
			lastpos = curpos;
			curpos.y++;
			gotoxy(curpos.x, curpos.y);
			cout << "#";
			break;
		case 'L':
			gotoxy(curpos.x, curpos.y);
			if (ch_dir) { cout << ch_dir; ch_dir = 0; }
			else cout << "Í";
			lastpos = curpos;
			curpos.x--;
			gotoxy(curpos.x, curpos.y);
			cout << "#";
			break;
		case 'R':
			gotoxy(curpos.x, curpos.y);
			if (ch_dir) { cout << ch_dir; ch_dir = 0; }
			else cout << "Í";
			lastpos = curpos;
			curpos.x++;
			gotoxy(curpos.x, curpos.y);
			cout << "#";
			break;
		default: break;
		}
	}

	void addTail(int &n) {
		POINT* arr = new POINT[n + 1];
		for (size_t i = 0; i < n; i++) {
			arr[i] = tail[i];
		}
		arr[n] = lastpos;
		n++;
		tail = arr;
		delete[] arr;
	}

	void lost() {
		gotoxy(curpos.x, curpos.y);
		SetColor(Red, Black);
		cout << "#";
		SetColor(White, Black);
	}

	void reload() {
		color = White;
		direction = NULL;
		ch_dir = NULL;
		loss = false;
		curpos = { NULL };
		lastpos = { NULL };
		tail = nullptr;
	}
};