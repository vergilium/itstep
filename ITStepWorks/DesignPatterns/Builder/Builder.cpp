#include<iostream>
#include"AircraftBuilder.h"
#include"AircraftConstructor.h"
#include"HangGliderBuilder.h"
#include"GliderBuilder.h"

using namespace std;

int main() {
	try {
		AircraftBuilder* builder;

		// Создаем объект класса директора
		AircraftConstructor* shop = new AircraftConstructor();

		// Создаем объект класса строителя. Этот объект умеет создавать дельтапланы
		builder = new HangGliderBuilder();

		// сооружаем дельтаплан
		shop->Construct(builder);

		// показываем информацию о дельтаплане
		builder->GetAircraft()->Show();

		// Создаем объект класса строителя. Этот объект умеет создавать планеры
		delete builder;

		builder = new GliderBuilder();

		// сооружаем планер
		shop->Construct(builder);

		// показываем информацию о планере
		builder->GetAircraft()->Show();

		delete builder;
		delete shop;
	}
	catch (char* str) {
		cout << endl << str << endl;
	}

	
	return 0;
}