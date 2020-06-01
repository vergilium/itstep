#include<iostream>
#include "Context.h"
#include<list>
#include "BaseExpression.h"
#include "TerminalExpression.h"
#include "NonterminalExpression.h"

using namespace std;

int main()
{

	Context obj;
	list<BaseExpression*> expressions;

	expressions.push_front(new TerminalExpression());
	expressions.push_front(new NonterminalExpression());

	expressions.push_front(new TerminalExpression());
	expressions.push_front(new TerminalExpression());
	expressions.push_front(new TerminalExpression());
	


	auto move = expressions.begin();

	BaseExpression* pClear;

	while (move != expressions.end())
	{
		(*move)->Interpret(&obj);

		pClear = *move;
		
		move++;

		if(move != expressions.end())
			expressions.remove(pClear);
	}

	return 0;
}



