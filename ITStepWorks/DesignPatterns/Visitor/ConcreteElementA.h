#pragma once
#include "Element.h"

class ConcreteElementA :
	public Element
{
public:
	ConcreteElementA();
	~ConcreteElementA();

	void Accept(BaseVisitor* pVisitor);
};

