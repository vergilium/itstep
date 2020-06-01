#include "ConcreteIterator.h"
#include "ConcreteAggregate.h"


ConcreteIterator::ConcreteIterator(ConcreteAggregate* ptr)
{
	pCurrent = ptr;
}


ConcreteIterator::~ConcreteIterator()
{
}

int* ConcreteIterator::First()
{
	return (*pCurrent)[0];
}

int* ConcreteIterator::Next()
{
	if (currentIndex >= (*pCurrent).GetCount()) {
		return nullptr;
	}
	return (*pCurrent)[++currentIndex];
}

int* ConcreteIterator::CurrentItem()
{
	return (*pCurrent)[currentIndex];
}

bool ConcreteIterator::IsFinished()
{
	return currentIndex >= (*pCurrent).GetCount();
}
