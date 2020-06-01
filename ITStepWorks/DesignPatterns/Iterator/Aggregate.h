#pragma once
class BaseIterator;

// базовый класс в котором будет храниться внутренний массив
class Aggregate
{
public:
	Aggregate();
	~Aggregate();

	virtual  BaseIterator* CreateIterator() =0;
};

