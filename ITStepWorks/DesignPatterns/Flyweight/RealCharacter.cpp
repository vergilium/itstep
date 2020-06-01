#include "RealCharacter.h"
#include <iostream>


RealCharacter::RealCharacter(char pSymbol, int pPointSize)
{
	symbol = pSymbol;
	width = 100;
	height = 90;
	ascent = 40;
	descent = 0;
	pointSize = pPointSize;
}


RealCharacter::~RealCharacter()
{
}

void RealCharacter::Show() const
{
	std::cout << "\n" << "Symbol is:" << symbol << " Size:" << pointSize << std::endl;
}
