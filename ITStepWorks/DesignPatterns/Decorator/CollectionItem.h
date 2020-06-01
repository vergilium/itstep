#pragma once
class CollectionItem
{
public:
	CollectionItem();
	virtual ~CollectionItem();
private:
	int numberOfCopies;
public:
	virtual void Show() const = 0;
public:
	int GetNumberOfCopies()const
	{
		return numberOfCopies;
	}
	void SetNumberOfCopies(int value)
	{
		numberOfCopies = value;
	}
};

