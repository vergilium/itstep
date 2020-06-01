#pragma once

#include<iostream>
#include<string>
using namespace std;

// Класс фирмы
class Firm
{
public:
	// конструктора и деструктор
	Firm();
	Firm(string fName,bool bLicense,bool eLicense, bool cLicense);
	virtual ~Firm();

private:
	// название фирмы
	string name;
	// есть ли строительная лицензия у фирмы
	bool builderLicense;
	// есть ли экологическое разрешение
	bool environmentalLicense;
	// есть ли разрешение от города
	bool cityLicense;


public:
	// функции для работы с именем
	string GetName() {
		return name;
	}
	void SetName(string fName) {
		name = fName;
	}
	// функции для работы со строительной лицензии
	bool GetBuilderLicense(){
		return builderLicense;
	}
	void SetBuilderLicense(bool bLicense){
		builderLicense = bLicense;
	}
	// функции для работы с экологическим разрешением
	bool GetEnvironmentalLicense() {
		return environmentalLicense;
	}
	void SetEnvironmentalLicense(bool eLicense) {
		environmentalLicense = eLicense;
	}
	// функции для работы с городским разрешением
	bool GetCityLicense() {
		return cityLicense;
	}
	void SetCityLicense(bool cLicense) {
		cityLicense = cLicense;
	}


};

