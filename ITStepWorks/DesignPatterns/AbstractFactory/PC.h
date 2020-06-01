#pragma once
#include<iostream>
#include"Devices.h"
using namespace std;

// класс, описывающий компьютер  и его составл€ющие
class PC {
	Box* box;
	Processor* processor;
	MainBoard* mainBoard;
	Hdd* hdd;
	Memory* memory;
public:
	PC() {
		box = NULL;
		processor = NULL;
		mainBoard = NULL;
		hdd = NULL;
		memory = NULL;
	}
	virtual ~PC() {
		if (box)
			delete box;

		if (processor)
			delete processor;

		if (mainBoard)
			delete mainBoard;

		if (hdd)
			delete hdd;

		if (memory)
			delete memory;
	}
	Box* GetBox() {
		return box;
	}
	void SetBox(Box* pBox){
		box = pBox;
	}

	Processor* GetProcessor() {
		return processor;
	}
	void SetProcessor(Processor* pProcessor) {
		processor = pProcessor;
	}

	MainBoard* GetMainBoard() {
		return mainBoard;
	}
	void SetMainBoard(MainBoard* pMainBoard) {
		mainBoard = pMainBoard;
	}

	Hdd* GetHdd() {
		return hdd;
	}
	void SetHdd(Hdd* pHdd) {
		hdd = pHdd;
	}

	Memory* GetMemory() {
		return memory;
	}
	void SetMemory(Memory* pMemory) {
		memory = pMemory;
	}
};
