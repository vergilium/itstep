#include<iostream>
#include "Car.h"
#include<time.h>

using namespace std;

int main() {

	// Введем данные
	string manufacturer;
	cout << endl << "Input manufacturer of car:" << endl;
	std::getline(std::cin, manufacturer);

	string description;
	cout << "Input description of car:" << endl;
	std::getline(std::cin, description);

	string color;
	cout << "Input color of car:" << endl;
	std::getline(std::cin, color);

	int year;
	cout << "Input year of car:" << endl;
	cin >> year;

	// создадим объект
	Car c(manufacturer, description, color, year);
	c.Show();

	cout << "Let's clone!\nLet's prototype!" << endl;

	// клонируем объект
	Car* copy = (Car*)c.Clone();
	copy->Show();
	// удаляем клонированный объект
	delete copy;

	return 0;
}