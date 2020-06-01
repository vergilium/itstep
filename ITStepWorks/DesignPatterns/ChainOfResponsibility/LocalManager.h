#pragma once
#include <iostream>
#include "Manager.h"

using namespace std;

class LocalManager :
	public Manager
{
public:

	LocalManager()
	{
	}

	~LocalManager()
	{
	}

	void Process(const Claim& request)
	{
		if(request.GetAmount()<1000.0)
		{
			cout << "\nYour request was approved by local manager. Here is information about it\n";
			cout << request.GetTypeOfClaim() << " " << request.GetFrom() << " "<<request.GetAmount() << "\n";
		}
		else
		{
			pSuccessor->Process(request);
		}
	}
};

