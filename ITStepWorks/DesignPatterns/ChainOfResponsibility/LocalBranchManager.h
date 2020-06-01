#pragma once
#include "Manager.h"
#include <iostream>

class LocalBranchManager :
	public Manager
{
public:

	LocalBranchManager()
	{
	}

	~LocalBranchManager()
	{
	}

	void Process(const Claim& request)
	{
		if (request.GetAmount()<10000.0)
		{
			cout << "\nYour request was approved by local branch manager. Here is information about it\n";
			cout << request.GetTypeOfClaim() << " " << request.GetFrom() << " " << request.GetAmount() << "\n";
		}
		else
		{
			pSuccessor->Process(request);
		}
	}
};

