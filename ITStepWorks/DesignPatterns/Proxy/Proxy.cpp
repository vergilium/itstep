#include<iostream>
#include "MathProxy.h"
using namespace std;

int main() {
	
	
	// Создаем прокси
	MathematicsProxy* proxy = new MathematicsProxy();

	// Вызываем математические функции
	// сложение
	cout <<"7 + 11 = " << proxy->Addition(7, 11)<<endl;
	// вычитание
	cout << "6 - 8 = " << proxy->Subtraction(6, 8) << endl;
	// умножение
	cout << "5 * 7 = " << proxy->Multiplication(5, 7) << endl;
	// деление
	cout << "33 / 11 = " << proxy->Division(33, 11) << endl;

	delete proxy;

	return 0;
}