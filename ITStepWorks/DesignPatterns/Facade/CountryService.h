#pragma once
#include<iostream>
#include"Firm.h"
using namespace std;

// класс, отвечающий за проверку наличия лицензии на строительство у фирмы
class CountryService
{
public:
	CountryService();
	virtual ~CountryService();
	// есть ли у фирмы лицензия на строительство со стороны страны
	bool HasBuildingLicense(Firm* pFirm) {
		return pFirm->GetBuilderLicense() ? true : false;
	}
};

