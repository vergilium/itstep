#pragma once
#include<iostream>
#include <string>
using namespace std;
#include "CollectionItem.h"


class Book :
	public CollectionItem
{
public:
	Book(string, string, string, int);
	virtual ~Book();
private:
	string author;
	string style;
	string title;
public:
	void Show() const;
};