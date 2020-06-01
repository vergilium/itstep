#pragma once
#include "BaseExpression.h"
#include <iostream>
using namespace std;

class TerminalExpression :
	public BaseExpression
{
public:
	TerminalExpression();
	~TerminalExpression();


	void Interpret(Context* context){
		cout << "\nTerminalExpression  version of Interpret\n";
	}
};

