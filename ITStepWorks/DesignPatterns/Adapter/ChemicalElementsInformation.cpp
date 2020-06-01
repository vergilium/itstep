#include "ChemicalElementsInformation.h"
#include <algorithm>


ChemicalElementsInformation::ChemicalElementsInformation()
{
}


ChemicalElementsInformation::~ChemicalElementsInformation()
{
}

double ChemicalElementsInformation::GetDensity(string pName) const
{
	transform(pName.begin(), pName.end(), pName.begin(), ::tolower);
	if (pName == "silicon")
	{
		return 2.33;
	}
	else if (pName == "aluminum")
	{
		return 2.7;
	}
	else if (pName == "barium")
	{
		return 3.76;
	}
	return 0;
	
}

int ChemicalElementsInformation::GetPositionFromPeriodicTable(string pName) const
{
	transform(pName.begin(), pName.end(), pName.begin(), ::tolower);
	if (pName == "silicon")
	{
		return 14;
	}
	else if (pName == "aluminum")
	{
		return 13;
	}
	else if (pName == "barium")
	{
		return 56;
	}
	return -1;
}
