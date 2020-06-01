#pragma once
#include<iostream>
#include<string>
using namespace std;

/* 
 *  Это абстрактный базовый класс Device.
 *  Он определяет функцию Clone, которая составляет 
 *  основу паттерна Prototype
 */
class Device {
private:
	// название устройства
	string name;
public:
	// конструктора
	Device() : Device("Unknown device") {}
	Device(string dname){
		SetName(dname);
	}
	// вспомогательные функции
	string GetName() const{
		return name;
	}
	void SetName(string dname) {
		name = dname;
	}
	// Чисто виртуальная функция
	// Она будет использоваться для создания копий
	virtual Device* Clone() const = 0;

	// отображение данных
	void Show() const{
		cout << "\nName is\n" << GetName() << "\n";
	}
};
