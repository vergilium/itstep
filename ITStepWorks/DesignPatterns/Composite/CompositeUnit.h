#pragma once
#include "Unit.h"
#include <vector>
using namespace std;

class CompositeUnit :
	public Unit
{
public:
	CompositeUnit();
	virtual ~CompositeUnit();
public:
	int GetPower()const;
	void AddUnit(Unit* p);
private:
	std::vector<Unit*> fleet;
};


