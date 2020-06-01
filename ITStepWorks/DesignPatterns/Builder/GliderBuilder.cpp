#include "GliderBuilder.h"



GliderBuilder::GliderBuilder()
{
	aircraft = new Aircraft("Glider");
}


GliderBuilder::~GliderBuilder()
{
	delete aircraft;
}

void GliderBuilder::BuildFrame() {
	aircraft->SetPart("frame", "Glider frame");
}

void GliderBuilder::BuildEngine() {
	aircraft->SetPart("engine", "no engine");
}

void GliderBuilder::BuildWheels() {
	aircraft->SetPart("wheels", "1");
}

void GliderBuilder::BuildDoors() {
	aircraft->SetPart("doors", "1");
}

void GliderBuilder::BuildWings() {
	aircraft->SetPart("wings", "2");
}



