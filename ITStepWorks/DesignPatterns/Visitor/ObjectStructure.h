#pragma once
#include "Element.h"

#include <list>
using namespace std;

class ObjectStructure
{
	list<Element*> elements;
public:
	ObjectStructure();
	~ObjectStructure();

	void Attach(Element* pNew);
	
	void Detach(Element* pDelete);
	

	void Accept(BaseVisitor* pVisitor);
	
};


