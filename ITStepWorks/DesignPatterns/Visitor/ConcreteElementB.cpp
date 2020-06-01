#include "ConcreteElementB.h"



ConcreteElementB::ConcreteElementB()
{
}


ConcreteElementB::~ConcreteElementB()
{
}

void ConcreteElementB::Accept(BaseVisitor* pVisitor) {
	pVisitor->VisitConcreteElementB(this);
}