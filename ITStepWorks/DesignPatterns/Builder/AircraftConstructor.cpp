#include "AircraftConstructor.h"



AircraftConstructor::AircraftConstructor()
{
}


AircraftConstructor::~AircraftConstructor()
{
}

void AircraftConstructor::Construct(AircraftBuilder* aircraftBuilder)
{
	aircraftBuilder->BuildFrame();
	aircraftBuilder->BuildEngine();
	aircraftBuilder->BuildWheels();
	aircraftBuilder->BuildDoors();
}