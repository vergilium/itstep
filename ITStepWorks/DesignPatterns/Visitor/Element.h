#pragma once
#include "BaseVisitor.h"

class Element
{
public:
	Element();
	~Element();

	virtual void Accept(BaseVisitor* pVisitor) = 0;
};

