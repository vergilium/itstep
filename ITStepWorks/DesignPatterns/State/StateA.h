#pragma once
#include "BaseState.h"

class StateA : public BaseState
{
public:
	StateA();
	~StateA();
	
	// изменяем состояние на другое
	void Handle(Context* context);
	string GetNameOfState() const;
};

