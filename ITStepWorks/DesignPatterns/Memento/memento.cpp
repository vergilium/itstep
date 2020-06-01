#include<iostream>

#include "human.h"
#include "CareTaker.h"
using namespace std;



int main()
{
	// создаем объект человека
	Human h("Piter", "Dymos", 44);

	MemoryState obj;

	// сохраняем состояние
	obj.SetMemento(h.SaveMemento());
	// изменяем данные
	h.SetSurname("Dixy");
	h.SetName("Oliver");
	h.SetAge(45);
	// возвращаем состояние
	h.RestoreMemento(obj.GetMemento());
	
	cout << endl << h.GetName().c_str() << " " << h.GetSurname().c_str() << " " << h.GetAge()<<endl;

	return 0;
}