#pragma once

#include<string>
using namespace std;

class Context;

class BaseState
{
public:
	BaseState();
	~BaseState();
	virtual void Handle(Context* context) = 0;
	virtual string GetNameOfState()const = 0;
};

