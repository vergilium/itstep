#include <iostream>
#include "RemoteControl.h"
using namespace std;

int main()
{
	RemoteControl control;
	TV* concreteTV = new TV();

	TVCommand* tvOn = new TVOnCommand(concreteTV);
	TVCommand* tvOff = new TVOffCommand(concreteTV);

	
	// включаем телевизор
	control.SetCommand(tvOn);

	control.PressButton();

	//выключаем телевизор

	control.SetCommand(tvOff);

	control.PressButton();

	delete tvOff;
	delete tvOn;
	delete concreteTV;

	return 0;
}