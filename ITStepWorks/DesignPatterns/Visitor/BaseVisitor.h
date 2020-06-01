#pragma once
class ConcreteElementA;
class ConcreteElementB;

class BaseVisitor
{
public:
	BaseVisitor();
	~BaseVisitor();

	virtual void VisitConcreteElementA(ConcreteElementA* pA) = 0;
	virtual void VisitConcreteElementB(ConcreteElementB* pB) = 0;
};

