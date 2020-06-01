#pragma once
#include "CollectionItem.h"
class Decorator :
	public CollectionItem
{
public:
	Decorator(CollectionItem*);
	virtual ~Decorator();
protected:
	CollectionItem* item;
public:
	void Show()const
	{
		item->Show();
	}
};
