#pragma once
#include "Manager.h"
#include <iostream>

class CEO :
	public Manager
{
public:

	CEO()
	{
	}

	~CEO()
	{
	}

	void Process(const Claim& request)
	{
		if (request.GetAmount()<100000.0)
		{
			cout << "\nYour request was approved by CEO. Here is information about it\n";
			cout << request.GetTypeOfClaim() << " " << request.GetFrom() << " " << request.GetAmount() << "\n";
		}
		else
		{
			cout << "\nWe are not able to approve your claim\n";
		}
	}
};

