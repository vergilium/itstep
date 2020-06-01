#include "ConcreteAggregate.h"
#include "BaseIterator.h"
#include "ConcreteIterator.h"


ConcreteAggregate::ConcreteAggregate()
{
}


ConcreteAggregate::~ConcreteAggregate()
{
}

int ConcreteAggregate::GetCount()
{
	return size;
}

BaseIterator* ConcreteAggregate::CreateIterator()
{
	return new ConcreteIterator(this);
}