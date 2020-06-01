#pragma once
#include "Aggregate.h"
#include <iostream>
using namespace std;

class BaseIterator;

// реализация класса для хранения массива
class ConcreteAggregate :
	public Aggregate
{
	enum { size = 4 };
	int arr[size] = {0};
	
public:
	ConcreteAggregate();
	~ConcreteAggregate();

	BaseIterator* CreateIterator();
	

	int GetCount();
	int* operator[](int index)
	{
		if (index >= size) {
			return nullptr;
		}
		return &arr[index];
	}
};












