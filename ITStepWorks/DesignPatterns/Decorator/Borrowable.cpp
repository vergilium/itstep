#include "Borrowable.h"



Borrowable::Borrowable(CollectionItem* item):Decorator(item)
{
}


Borrowable::~Borrowable()
{
}

void Borrowable::BorrowItem(string name)
{
	users.push_back(name);
	item->SetNumberOfCopies(item->GetNumberOfCopies() - 1);
}

void Borrowable::ReturnItem(string name)
{
	auto result = std::find(users.begin(), users.end(), name);
	if (result != users.end()){
		users.erase(result);
		item->SetNumberOfCopies(item->GetNumberOfCopies() + 1);
	}

}

void Borrowable::Show() const
{
	for (auto ptr = users.begin();ptr != users.end();ptr++)
	{
		cout << "Member:" << (*ptr) << endl;
	}
}