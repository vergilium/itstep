#pragma once
#include "AircraftBuilder.h"

// Класс строителя. Умеет создавать дельтапланы

class HangGliderBuilder:public AircraftBuilder
{
public:

	HangGliderBuilder();
	virtual ~HangGliderBuilder();

public:

	void BuildFrame();

	void BuildEngine();

	void BuildWheels();

	void BuildDoors();

	void BuildWings();

};

