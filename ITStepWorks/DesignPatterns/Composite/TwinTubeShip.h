#pragma once
#include "Unit.h"
class TwinTubeShip :
	public Unit
{
public:

	TwinTubeShip()
	{
	}

	virtual ~TwinTubeShip()
	{
	}
public:
	int GetPower() const
	{
		return 2;
	}
	void AddUnit(Unit* p)
	{
		throw "This operation is not supported!";
	}
};

