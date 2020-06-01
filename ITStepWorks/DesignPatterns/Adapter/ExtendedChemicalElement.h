#pragma once
#include "ChemicalElement.h"
#include "ChemicalElementsInformation.h"

// Adapter
class ExtendedChemicalElement :
	public ChemicalElement
{  
private:
	ChemicalElementsInformation *pInformation;
public:
	ExtendedChemicalElement(string);
	virtual ~ExtendedChemicalElement();
	void Show();
};

