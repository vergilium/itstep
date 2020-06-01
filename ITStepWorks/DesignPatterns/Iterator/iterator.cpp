#include <iostream>
#include "ConcreteAggregate.h"
#include "BaseIterator.h"

using namespace std;

int main()
{
	// создаем объект класса внутри которого находится наш массив
	ConcreteAggregate* ptr = new ConcreteAggregate();

	*(*ptr)[0] = 5;
	*(*ptr)[1] = 7;
	*(*ptr)[2] = 8;

	// создаем итератор для прохода по внутреннему массиву
	BaseIterator* iterator = ptr->CreateIterator();

	// получаем доступ к первому элементу
	int *a = iterator->First();

	// цикл показа всех элементов
	while(a)
	{
		cout << *a << " ";
		a = iterator->Next();
	}
	// чистим за собой
	delete ptr;
	delete iterator;

	return 0;
}