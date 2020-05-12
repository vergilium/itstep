#include <iostream>
#include <locale.h>
#include <conio.h>
#include <Windows.h>
#include <future>
#include <atomic>
#include <time.h>

#include "Player.h"
#include "MainFunct.h"
#include "Maps.h"
#include "Storage.h"


using namespace std;

atomic<bool> TIMER0_ISR_vect = false;
atomic<bool> TIMER0_ENA = true;


enum MenuItems {
	NewGame, LiderBoard, Info, Exit 
};

//========================================
void Timer0(int H_msec) {
	while (TIMER0_ENA) {
		Sleep(H_msec*100);
		TIMER0_ISR_vect = true;
	}
}

inline void ViewScore(int score) {
	SetColor(White, Black);
	gotoxy(72, 2);
	cout << score;
}


int main() {
	int menu = 1;
	int menuIndex = 0;
	int x = 0, y = 0;
	int n_step = 1;

	srand(time(0));

	future<void> asyncTimer = async(&Timer0, 2);

	MOTO moto_p1, moto_p2;

start:
	
	moto_p1.init(Green, 'L', { P_RAND(10, 30), P_RAND(10, 10) });
	moto_p2.init(Blue, 'R', { P_RAND(31,60), P_RAND(10,20) });
	
	setup();
	
	menuIndex = MainMenu();
	
	switch (menuIndex) {
	case NewGame:  EnterNames(moto_p1, moto_p2); GraphCanvas();
		TIMER0_ENA = true;
		while (true) {
			if (TIMER0_ISR_vect && TIMER0_ENA) {
				TIMER0_ISR_vect = false;
				if (!fild_out(moto_p1) && !find_tail(moto_p1.tail, n_step, moto_p1) && !find_tail(moto_p2.tail, n_step, moto_p1) && \
					!fild_out(moto_p2) && !find_tail(moto_p2.tail, n_step, moto_p2) && !find_tail(moto_p1.tail, n_step, moto_p2)) {
						moto_p1.addTail(n_step);
						moto_p2.addTail(n_step);
						moto_p1.move();
						moto_p2.move();
						ViewScore(n_step);
			
				}
				else{
					if (moto_p1.loss == true) moto_p1.lost();
					if (moto_p2.loss == true) moto_p2.lost();
					TIMER0_ENA = false;							//Остановка таймера
					Sleep(3000);
					system("cls");
					SetColor(White, Red);
					cout << GAME_OVER_MAP;
					//////
					//Вывод статистики по игре
					//////
					gotoxy(10, 10);
					cout << moto_p1.name << " : " << (!moto_p1.loss?"WIN":"LOST");
					if (!moto_p1.loss) {
						cout << "  Score =  " << n_step;
						WriteStat(moto_p1.name, n_step);
					}
					gotoxy(10, 12);
					cout << moto_p2.name << " : " << (!moto_p2.loss?"WIN":"LOST");
					if (!moto_p2.loss) {
						cout << "  Score =  " << n_step;
						WriteStat(moto_p2.name, n_step);
					}
					
				}
				
			}
			if (_kbhit()) { 
				switch (_getch()) {
				case VK_ESCAPE: goto start;
					break;
				case VK_RETURN: 
					if (!TIMER0_ENA) {
						moto_p1.reload();
						moto_p2.reload();
						n_step = 1;
						goto start;
					}
					break;
					/////////////////////////////////////////////////////
					/////////PLAYER ONE CONTROLS////////////////////////
				case VK_UP:
					if(moto_p1.direction == 'L') moto_p1.ch_dir = LtoT;
					if (moto_p1.direction == 'R') moto_p1.ch_dir = RtoT;
					if (moto_p1.direction != 'B') moto_p1.direction = 'T';
					break;
				case VK_DOWN:
					if (moto_p1.direction == 'L') moto_p1.ch_dir = LtoB;
					if (moto_p1.direction == 'R') moto_p1.ch_dir = RtoB;
					if (moto_p1.direction != 'T') moto_p1.direction = 'B';
					break;
				case VK_LEFT:  
					if (moto_p1.direction == 'T') moto_p1.ch_dir = TtoL;
					if (moto_p1.direction == 'B') moto_p1.ch_dir = BtoL;
					if (moto_p1.direction != 'R') moto_p1.direction = 'L';
					break;
				case VK_RIGHT:
					if (moto_p1.direction == 'T') moto_p1.ch_dir = TtoR;
					if (moto_p1.direction == 'B') moto_p1.ch_dir = BtoR;
					if (moto_p1.direction != 'L') moto_p1.direction = 'R';
					break;
					/////////////////////////////////////////////////////
					/////////PLAYER TWO CONTROLS////////////////////////
				case VK_W:
					if (moto_p2.direction == 'L') moto_p2.ch_dir = LtoT;
					if (moto_p2.direction == 'R') moto_p2.ch_dir = RtoT;
					if (moto_p2.direction != 'B') moto_p2.direction = 'T';
					break;
				case VK_S:
					if (moto_p2.direction == 'L') moto_p2.ch_dir = LtoB;
					if (moto_p2.direction == 'R') moto_p2.ch_dir = RtoB;
					if (moto_p2.direction != 'T') moto_p2.direction = 'B';
					break;
				case VK_D:
					if (moto_p2.direction == 'T') moto_p2.ch_dir = TtoL;
					if (moto_p2.direction == 'B') moto_p2.ch_dir = BtoL;
					if (moto_p2.direction != 'R') moto_p2.direction = 'L';
					break;
				case VK_A:
					if (moto_p2.direction == 'T') moto_p2.ch_dir = TtoR;
					if (moto_p2.direction == 'B') moto_p2.ch_dir = BtoR;
					if (moto_p2.direction != 'L') moto_p2.direction = 'R';
					break;
				}
				Sleep(100);
			}
		}
		break;
	case LiderBoard: 
		ViewStat();
		while (true) {
			if (!_kbhit()) {
				if (_getch() == VK_ESCAPE) break;
			}
		}

		break;
	case Info: FillInfo(); break;
	case Exit: exit(0); break; 
	default: break;
	}
	goto start;
	
	return 0;
}