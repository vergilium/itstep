#pragma once
#include "Context.h"

class BaseExpression
{
public:
	BaseExpression();
	~BaseExpression();
	virtual void Interpret(Context* context) = 0;
};

