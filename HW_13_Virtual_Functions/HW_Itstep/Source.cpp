#include <iostream>

#include "Employer.h"
#include "Area.h"

using namespace std;



int main() {
	int task = 0;
	for (size_t i = 0; i < 4; i++) {
		cout << "Enter task number from 1 to 5" << endl;
		cin >> task;
		if (task < 0 && task >5) cout << "Wrong task number!" << endl;
		else break;
	}

	Employer* P = new President("Stiv", "Jobs", Male, 24, 404, 51);
	Employer* M = new Manager("Alex", "Vergilium", Male, 38, 301, "Marketing");
	Employer* W = new Worker("Oleg", "Ivanov", "Electrical", Male, 42, "tech servise", 2136);

	Area* areas[4] = { new Rectangle(10,20),
					new Cicle(10),
					new RightTriangle(10,20),
					new Trapeze(10,20,5)};

	switch (task) {
	case 1:
		P->print();
		M->print();
		W->print();
		break;
	case 2:
		break;
	case 3:
		for (size_t i=0; i < 4; ++i) {
			cout << "Shape: " << areas[i]->getShape() << " area = " << areas[i]->area() << endl;
		}
	}


	return 0;
}