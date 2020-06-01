#pragma once
#include "TVCommands.h"

class RemoteControl {

private:
	TVCommand* command;
public:
	void SetCommand(TVCommand* pCommand) {
		command = pCommand;
	}
	void PressButton() {
		command->Execute();
	}
};
