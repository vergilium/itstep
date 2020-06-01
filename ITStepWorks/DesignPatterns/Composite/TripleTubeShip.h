#pragma once
#include "Unit.h"
class TripleTubeShip :
	public Unit
{
public:

	TripleTubeShip()
	{
	}

	virtual ~TripleTubeShip()
	{
	}
public:
	int GetPower() const
	{
		return 3;
	}
	void AddUnit(Unit* p)
	{
		throw "This operation is not supported!";
	}
};

