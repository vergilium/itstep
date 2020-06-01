#include "HangGliderBuilder.h"
#include "Aircraft.h"



HangGliderBuilder::HangGliderBuilder()
{
	aircraft = new Aircraft("Hang Glider");

}

HangGliderBuilder::~HangGliderBuilder()
{
	delete aircraft;
}

void HangGliderBuilder::BuildFrame() {
	aircraft->SetPart("frame", "Hang glider frame");
}

void HangGliderBuilder::BuildEngine() {
	aircraft->SetPart("engine", "no engine");
}

void HangGliderBuilder::BuildWheels() {
	aircraft->SetPart("wheels", "no wheels");
}

void HangGliderBuilder::BuildDoors(){
	aircraft->SetPart("doors", "no doors");
}

void HangGliderBuilder::BuildWings() {
	aircraft->SetPart("wings", "1");
}