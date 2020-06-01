#pragma once
#include "BaseExpression.h"
#include <iostream>
using namespace std;

class NonterminalExpression :
	public BaseExpression
{
public:
	NonterminalExpression();
	~NonterminalExpression();

	void Interpret(Context* context) {
		cout << "\nNonTerminalExpression  version of Interpret\n";
	}
};

