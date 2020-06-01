#pragma once
class Unit
{
public:

	Unit()
	{
	}

	virtual ~Unit()
	{
	}
public:
	virtual int GetPower() const = 0;
	virtual void AddUnit(Unit* p) = 0;
};



