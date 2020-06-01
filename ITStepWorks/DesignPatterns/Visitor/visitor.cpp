#include <iostream>

#include "ObjectStructure.h"
#include "ConcreteElementA.h"
#include "ConcreteElementB.h"
#include "VisitorSecond.h"
#include "VisitorFirst.h"

using namespace std;

int main()
{
	
	
	ObjectStructure* o = new ObjectStructure();

	o->Attach(new ConcreteElementA());

	o->Attach(new ConcreteElementB());



	

	VisitorFirst* v1 = new VisitorFirst();

	VisitorSecond* v2 = new VisitorSecond();


	

	o->Accept(v1);

	o->Accept(v2);

	delete o;
	delete v1;
	delete v2;


	return 0;
}