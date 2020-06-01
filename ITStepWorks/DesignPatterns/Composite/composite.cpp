#include<iostream>
#include<vector>
#include "CompositeUnit.h"
#include "MonoTubeShip.h"
#include "TwinTubeShip.h"
#include "TripleTubeShip.h"
#include "FourTubeShip.h"
using namespace std;



// Функция для создания флота
CompositeUnit* CreateFleet()
{
	
	CompositeUnit* fleet = new CompositeUnit;
	// добавим 4 однотрубных корабля
	for (int i = 0; i<4; ++i)
		fleet->AddUnit(new MonoTubeShip());
	// добавим 3 двухтрубных корабля
	for (int i = 0; i<3; ++i)
		fleet->AddUnit(new TwinTubeShip());
	// добавим 2 трехтрубных корабля
	for (int i = 0; i<2; ++i)
		fleet->AddUnit(new TripleTubeShip());

	// добавим один четырехтрубных корабель
	fleet->AddUnit(new FourTubeShip());

	return fleet;
}

int main()
{
	// Давайте создадим наш флот!
	CompositeUnit* fleet = CreateFleet();

	cout << "Full power of our fleet:" << fleet->GetPower()<<endl;
	delete fleet;

	return 0;
}