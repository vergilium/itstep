#include<iostream>
#include "ChemicalElement.h"
#include "ExtendedChemicalElement.h"
using namespace std;
int main()
{
	ChemicalElement *ptr = new ExtendedChemicalElement("silicon");
	ptr->Show();
	delete ptr;

	ptr = new ExtendedChemicalElement("aluminum");
	ptr->Show();
	delete ptr;

	ptr = new ExtendedChemicalElement("barium");
	ptr->Show();
	delete ptr;

	return 0;
}