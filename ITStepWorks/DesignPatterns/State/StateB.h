#pragma once

#include <string>
#include "BaseState.h"
using namespace std;

class StateB:public BaseState
{
public:
	StateB();
	~StateB();
	// изменяем состояние на другое
	void Handle(Context* context);
	string GetNameOfState() const;
};

