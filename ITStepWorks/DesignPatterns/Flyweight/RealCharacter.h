#pragma once
#include "AbstractCharacter.h"

class RealCharacter :
	public AbstractCharacter
{
public:
	RealCharacter(char,int);
	virtual ~RealCharacter();
	void Show()const;
};

