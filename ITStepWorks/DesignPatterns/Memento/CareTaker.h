#pragma once
#include "Memento.h"
// класс CareTaker
// используется для хранения состояния
class MemoryState
{
private:
	Memento* ptrMemento = nullptr;
public:

	Memento* GetMemento() const
	{
		return ptrMemento;
	}
	void SetMemento(Memento *pMemento)
	{
		ptrMemento = pMemento;
	}
	~MemoryState()
	{
		if (ptrMemento)
			delete ptrMemento;
	}
};