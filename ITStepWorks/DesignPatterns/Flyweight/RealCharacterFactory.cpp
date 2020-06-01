#include "RealCharacterFactory.h"



RealCharacterFactory::RealCharacterFactory()
{
}


RealCharacterFactory::RealCharacterFactory(int pPointSize)
{
	pointSize = pPointSize;
}

RealCharacterFactory::~RealCharacterFactory()
{
	for (map<char, const AbstractCharacter*>::const_iterator first = chars.begin(); first != chars.end(); first++)
		delete first->second;
}


const AbstractCharacter& RealCharacterFactory::GetChar(char key)
{
	map<char,const AbstractCharacter*>::const_iterator result = chars.find(key);
	if(chars.end() == result)
	{
		const RealCharacter* newCharacter = new RealCharacter(key, pointSize);
		chars[key] = newCharacter;
		return *newCharacter;
	}
	return *result->second;
}
