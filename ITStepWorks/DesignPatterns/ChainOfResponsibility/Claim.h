#pragma once
#include <string>
using namespace std;
class Claim
{
	string typeOfClaim;
	string from;
	double amountOfMoney;

public:

	Claim(string t="",string f="",double a=0.0):typeOfClaim(t),from(f),amountOfMoney(a)
	{
	}

	string GetTypeOfClaim() const
	{
		return typeOfClaim;
	}
	void SetTypeOfClaim(string t)
	{
		typeOfClaim = t;
	}

	string GetFrom() const
	{
		return from;
	}
	void SetFrom(string f)
	{
		from = f;
	}

	double GetAmount() const
	{
		return amountOfMoney;
	}
	void SetAmount(double a)
	{
		amountOfMoney = a;
	}

	~Claim()
	{
	}
};

