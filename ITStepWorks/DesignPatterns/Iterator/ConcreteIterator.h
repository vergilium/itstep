#pragma once
#include "BaseIterator.h"


class ConcreteAggregate;

// реализация итератора
class ConcreteIterator :
	public BaseIterator
{
	ConcreteAggregate* pCurrent;
	int currentIndex = 0;
public:
	ConcreteIterator(ConcreteAggregate*);
	~ConcreteIterator();

	int* First();
	int* Next();
	int* CurrentItem();

	bool IsFinished();

};