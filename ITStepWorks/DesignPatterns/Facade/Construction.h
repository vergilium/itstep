#pragma once
#include<iostream>
using namespace std;

#include"EnvironmentalService.h"
#include"CityService.h"
#include"CountryService.h"

// Класс Facade. Осуществляет комплексную проверку
// на наличие всех лицензий и доступа у фирмы-строителя
class Construction
{
	EnvironmentalService eService;
	CityService cService;
	CountryService coService;

public:
	Construction();
	virtual ~Construction();
	bool IsAllowed(Firm* pFirm);
};

