#pragma once
#include "BaseState.h"

// класс контекста
// его внутреннее состояние будет меняться
class Context
{
	// переменная для внутреннего состояния
	BaseState* pCurrent = nullptr;
public:

	Context(BaseState* pTemp)
	{
		pCurrent = pTemp;
	}

	~Context()
	{
		if (pCurrent)
			delete pCurrent;
	}
public:
	// возвращаем внутреннее состояние
	BaseState* GetState()
	{
		return pCurrent;
	}
	// изменяем внутреннее состояние
	void SetState(BaseState* pTemp)
	{
		if (pCurrent)
			delete pCurrent;
		
		pCurrent = pTemp;
	}
	// выполняем некоторое действие в результате, которого меняется внутренее состояние
	void Request()
	{
		pCurrent->Handle(this);
	}
};




