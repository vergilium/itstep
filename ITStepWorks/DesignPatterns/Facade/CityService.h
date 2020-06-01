#pragma once
#include<iostream>
using namespace std;

#include "Firm.h"

// класс, отвечающий за проверку прав на строительство от городских служб
class CityService
{
public:
	CityService();
	virtual ~CityService();
	// есть ли у фирмы разрешение на строительство со города
	bool HasCityAccess(Firm* pFirm) {
		return pFirm->GetCityLicense() ? true : false;
	}
};

