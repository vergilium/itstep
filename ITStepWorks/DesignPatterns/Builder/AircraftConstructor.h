#pragma once
#include "AircraftBuilder.h"

// класс директора умеет создавать конкретный продукт с помощью строителя
class AircraftConstructor
{
public:
	AircraftConstructor();
	virtual ~AircraftConstructor();
	void Construct(AircraftBuilder* aircraftBuilder);
};

