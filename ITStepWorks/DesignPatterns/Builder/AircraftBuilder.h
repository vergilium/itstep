#pragma once
#include "Aircraft.h"

// абстрактный класс строителя
class AircraftBuilder
{
public:
	AircraftBuilder();
	virtual ~AircraftBuilder();
protected:
	Aircraft* aircraft;
public:
	Aircraft* GetAircraft() {
		return aircraft;
	}

	virtual void BuildFrame() = 0;

	virtual void BuildEngine() = 0;

	virtual void BuildWheels() = 0;

	virtual void BuildDoors() = 0;

	virtual void BuildWings() = 0;

};





