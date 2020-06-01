#include "CompositeUnit.h"



CompositeUnit::CompositeUnit()
{
}


CompositeUnit::~CompositeUnit()
{
	for (int i = 0; i<fleet.size(); ++i)
		delete fleet[i];
}

int CompositeUnit::GetPower() const
{
	int amount = 0;
	for (int i = 0; i < fleet.size(); i++) {
		amount += fleet[i]->GetPower();
	}
	return amount;
}

void CompositeUnit::AddUnit(Unit* p)
{
	fleet.push_back(p);
}

