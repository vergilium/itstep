#pragma once
#include "Device.h"
#include <iostream>
using namespace std;

class Airplane :
	public Device
{
public:

	Airplane()
	{
	}

	virtual ~Airplane()
	{
	}
public:
	void MakeEngine()
	{
		cout << "\nMake Engine for Airplane\n";
	}
	void MakeWheels()
	{
		cout << "\nMake Wheels for Airplane\n";
	}
	void MakeCabin()
	{
		cout << "\nMake Cabin for Airplane\n";
	}
	void MakeWings()
	{
		cout << "\nMake Wings for Airplane\n";
	}
};

