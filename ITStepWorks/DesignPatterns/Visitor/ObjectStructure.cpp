#include "ObjectStructure.h"



ObjectStructure::ObjectStructure()
{
}


ObjectStructure::~ObjectStructure()
{
}
void ObjectStructure::Attach(Element* pNew)
{
	elements.push_front(pNew);
}
void ObjectStructure::Detach(Element* pDelete)
{
	elements.remove(pDelete);
}
void ObjectStructure::Accept(BaseVisitor* pVisitor)
{
	auto start = elements.begin();

	while (start != elements.end())
	{
		(*start)->Accept(pVisitor);
		start++;
	}
}