#pragma once
#include<iostream>
#include<string>
#include<vector>
#include "CDecorator.h"
using namespace std;

class Borrowable :
	public Decorator
{
public:
	Borrowable(CollectionItem*);
	virtual ~Borrowable();
private:
	vector<string> users;
public:
	void BorrowItem(string name);

	void ReturnItem(string name);

	void Show() const;
};
