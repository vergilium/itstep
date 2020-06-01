#pragma once
#include<iostream>
#include<fstream>
#include<time.h>

using namespace std;


class Logger {
private:

	Logger() {
		pObj = NULL;
	}
	~Logger() {
		if (pObj) {
			delete pObj;
		}
	}
	static Logger* pObj;

public:
	static Logger* GetInstance() {
		if (!pObj) {
			pObj = new Logger();
		}
		return pObj;
	}
	void PutMessage(string message) {

		const time_t timer = time(NULL);
		fstream fObj("E:\\log.txt", ios::out | ios::in);
		if (!fObj) {
			cout << "\nError with file\n";
			exit(EXIT_FAILURE);
		}
		fObj <<message.c_str()<<"\t"<<ctime(&timer) << endl;
	}
};
