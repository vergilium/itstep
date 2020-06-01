#include "VisitorFirst.h"



VisitorFirst::VisitorFirst()
{
}


VisitorFirst::~VisitorFirst()
{
}

void VisitorFirst::VisitConcreteElementA(ConcreteElementA* pA)
{
	cout << "\nVisitor First\t Element A\n";
}
void VisitorFirst::VisitConcreteElementB(ConcreteElementB* pB)
{
	cout << "\nVisitor First\t Element B\n";
}