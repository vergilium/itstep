#pragma once
#include <string>
#include<iostream>
using namespace std;

#include "CollectionItem.h"


using namespace std;

class CD :
	public CollectionItem
{
public:
	CD(string, string, string, int, int);
	virtual ~CD();
private:
	string singer;
	string style;
	string title;
	int playtime;
public:
	void Show() const;
};

