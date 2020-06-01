#include "VisitorSecond.h"



VisitorSecond::VisitorSecond()
{
}


VisitorSecond::~VisitorSecond()
{
}
void VisitorSecond::VisitConcreteElementA(ConcreteElementA* pA)
{
	cout << "\nVisitor Second\t Element A\n";
}
void VisitorSecond::VisitConcreteElementB(ConcreteElementB* pB)
{
	cout << "\nVisitor Second\t Element B\n";
}