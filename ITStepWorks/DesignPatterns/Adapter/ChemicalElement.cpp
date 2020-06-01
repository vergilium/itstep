#include "ChemicalElement.h"
#include <algorithm>


ChemicalElement::ChemicalElement(string pName)
{
	name = pName;
	transform(name.begin(), name.end(), name.begin(), ::tolower);
}


ChemicalElement::~ChemicalElement()
{
}
