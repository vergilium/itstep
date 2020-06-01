#include<iostream>

#include "Device.h"
#include "Airplane.h"
#include "Car.h"

using namespace std;

int main()
{
	Device* device = new Car();
	device->Assemble();
	delete device;

	cout << "\n\n=====================\n\n";
	device = new Airplane();
	device->Assemble();
	delete device;

	return 0;
}