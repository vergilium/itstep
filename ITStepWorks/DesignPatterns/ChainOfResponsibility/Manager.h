#pragma once
#include "Claim.h"
class Manager
{
protected:
	Manager* pSuccessor;
public:
	void SetSuccessor(Manager* pTemp)
	{
		pSuccessor = pTemp;
	}
	virtual void Process(const Claim& request) = 0;
	virtual ~Manager(){}
};
