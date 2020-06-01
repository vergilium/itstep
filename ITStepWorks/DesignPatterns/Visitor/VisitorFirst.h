#pragma once
#include "BaseVisitor.h"
#include <iostream>
using namespace std;

class VisitorFirst :
	public BaseVisitor
{
public:
	VisitorFirst();
	~VisitorFirst();

	void VisitConcreteElementA(ConcreteElementA* pA);
	void VisitConcreteElementB(ConcreteElementB* pB);
};

