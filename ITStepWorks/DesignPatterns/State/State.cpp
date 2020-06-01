#include<iostream>
#include "Context.h"
#include "StateA.h"

using namespace std;

int main()
{
	Context obj(new StateA());

	obj.Request();
	obj.Request();
	obj.Request();
	obj.Request();

	return 0;
}

