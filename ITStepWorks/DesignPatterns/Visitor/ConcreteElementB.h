#pragma once
#include "Element.h"

class ConcreteElementB :
	public Element
{
public:
	ConcreteElementB();
	~ConcreteElementB();

	void Accept(BaseVisitor* pVisitor); 
};

