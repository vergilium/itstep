#pragma once
#include "Device.h"
#include <iostream>
using namespace std;

class Car :
	public Device
{
public:

	Car()
	{
	}

	virtual ~Car()
	{
	}
public:
	void MakeEngine()
	{
		cout << "\nMake Engine for Car\n";
	}
	void MakeWheels()
	{
		cout << "\nMake Wheels for Car\n";
	}
	void MakeCabin()
	{
		cout << "\nMake Cabin for Car\n";
	}
	void MakeWings()
	{
		cout << "\nNo wings for Car\n";
	}
};

