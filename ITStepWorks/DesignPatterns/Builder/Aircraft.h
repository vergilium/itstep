#pragma once
#include<iostream>
#include<string>
#include<map>
using namespace std;

// базовый класс для летального устройства
class Aircraft
{
public:
	Aircraft(string);
	virtual ~Aircraft();
private:
	// тип летательного устройства
	string aircraftType;
	// хранилище информации об устройстве
	map<string, string> parts;
public:
	// получение информации о конкретной части устройства
	string GetPart(const string& key) {
		if (!CheckForPart(key)) {
			throw "There is no such key!";
		}
		return parts[key];
	}
	// установка значения для конкретной части устройства
	void SetPart(const string& key, const string& value) {
		parts[key] = value;
	}
	// проверка на наличие части
	bool CheckForPart(const string& key) {
		return parts.find(key) != parts.end() ? true:false;
	}
	// отображение информации об летательном устройстве
	void Show();
};
