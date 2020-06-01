#pragma once

#include<map>
#include<iostream>
using namespace std;
#include "RealCharacter.h"

class RealCharacterFactory
{
public:
	RealCharacterFactory();
	RealCharacterFactory(int);
	virtual ~RealCharacterFactory();

private:
	map < char, const AbstractCharacter* > chars;
	int pointSize;
public:
	const AbstractCharacter& GetChar(char);
};
