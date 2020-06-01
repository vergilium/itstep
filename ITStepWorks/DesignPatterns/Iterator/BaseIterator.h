#pragma once

// базовый класс итератора
// в нем определены функции для прохода по массиву
class BaseIterator
{
	
public:
	BaseIterator();
	~BaseIterator();

	virtual int* First() = 0;
	virtual int* Next() = 0;
	virtual int* CurrentItem() = 0;

	virtual bool IsFinished() = 0;
	

};


