#pragma once
#include "BaseVisitor.h"
#include <iostream>
using namespace std;

class VisitorSecond :
	public BaseVisitor
{
public:
	VisitorSecond();
	~VisitorSecond();

	void VisitConcreteElementA(ConcreteElementA* pA);
	void VisitConcreteElementB(ConcreteElementB* pB);
	
};

