#include "ConcreteElementA.h"



ConcreteElementA::ConcreteElementA()
{
}


ConcreteElementA::~ConcreteElementA()
{
}

void ConcreteElementA::Accept(BaseVisitor* pVisitor) {
	pVisitor->VisitConcreteElementA(this);
}
