#pragma once
#include <string>
using namespace std;

// Adaptee
class ChemicalElementsInformation
{
public:
	ChemicalElementsInformation();
	virtual ~ChemicalElementsInformation();
public:
	double GetDensity(string) const;
	int GetPositionFromPeriodicTable(string) const;
};

