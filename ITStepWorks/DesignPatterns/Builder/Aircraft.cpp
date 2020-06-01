#include "Aircraft.h"



Aircraft::Aircraft(string type)
{
	aircraftType = type;
}


Aircraft::~Aircraft()
{
}

void Aircraft::Show() {
	cout<<"\n====================\n";

	cout<<"Aircraft Type:"<<aircraftType<<endl;

	cout << "Frame:" << parts["frame"] << endl;

	cout<<"Engine:"<<parts["engine"]<<endl;

	cout<<"Wheels:"<<parts["wheels"]<<endl;

	cout<<"Doors:"<<parts["doors"]<<endl;
}
