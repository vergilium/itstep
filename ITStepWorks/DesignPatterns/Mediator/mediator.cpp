#include<iostream>
#include "Classroom.h"
#include "Trainee.h"
using namespace std;


int main()
{
	// создаем объект классная комнатьа
	Classroom *classroom = new Classroom();

	// ученики математического класса
	Trainee* piter = new MathClass("Piter");
	Trainee* tim = new MathClass("Tim");
	Trainee* brad = new MathClass("Brad");
	Trainee* joana = new MathClass("Joana");

	// регистрируем их в классе
	classroom->Register(piter);
	classroom->Register(tim);
	classroom->Register(brad);
	classroom->Register(joana);

	// посылаем сообщения
	piter->Send("Brad", "3*3+7");
	joana->Send("Tim", "21-78*3");
	
	// очистка
	delete piter;
	delete tim;
	delete brad;
	delete joana;

	delete classroom;

	return 0;
}