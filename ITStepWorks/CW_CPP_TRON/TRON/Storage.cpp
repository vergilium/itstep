#pragma once

#include <iostream>
#include <fstream>
#include <stdlib.h>
#include <string>

#include "Storage.h"

//struct STAT {
//	string name;
//	int score;
//};

bool WriteStat(string& name, int score) {
	string buf[NUM_LINE];
	string delimiter = ":";
	string temp;
	char scr[10];
	int tmp = 0;
	int i = 0;
	fstream file;

	file.open(FILE_NAME, ios::in);
	if (file.is_open()) {
		while (file.good()) {
			getline(file, buf[i], '\n');
			i++;
		}
	}
	file.close();

	_itoa_s(score, scr, 10);
	buf[NUM_LINE-1] = name+":"+scr;

	for (int i = 0; i < NUM_LINE - 1; i++) {
		for (int j = 0; j < NUM_LINE - i - 1; j++) {
			if (buf[j].substr(0, buf[j].find(delimiter)) > buf[j+1].substr(0, buf[j+1].find(delimiter))) {
				// меняем элементы местами
				temp = buf[j];
				buf[j] = buf[j + 1];
				buf[j + 1] = temp;
			}
		}
	}

	file.open(FILE_NAME, ios::out);
	if (file.is_open()) {
		for (int i = 0; i < NUM_LINE; i++) {
			if(buf[i] != "")
				file << buf[i] << endl;
		}
		file.close();
		return 0;
	}
	else
		return 1;
}

int ReadStat(string *&str) {
	ifstream file;
	//string buf[NUM_LINE];

	file.open(FILE_NAME);
	if (file.is_open()) {
		int i = 0;
		while (i < NUM_LINE-1) {
			getline(file, str[i], '\n');
			i++;
		}

		file.close();
		return 0;
	}
	else return 1;

}