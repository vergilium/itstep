#include<iostream>
#include "Construction.h"
#include "Firm.h"

using namespace std;

int main() {

	// Создаем объект фасада Facade
	Construction constructor;

	// Создаем объект фирмы
	Firm myfirm("DreamBuilder", true, true, false);
	
	// Проверяем все ли разрешения есть у фирмы на строительство
	bool allowable = constructor.IsAllowed(&myfirm);

	cout << myfirm.GetName() << ((allowable) ? " will build\n\n" : " won't build\n\n");

	return 0;
}