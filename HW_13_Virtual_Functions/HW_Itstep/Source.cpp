#include <iostream>

#include "Employer.h"
#include "Area.h"
#include "list.h"
#include "Equation.h"

using namespace std;



int main() {
	int task = 0;
	for (size_t i = 0; i < 4; i++) {
		cout << "Enter task number from 1 to 5" << endl;
		cin >> task;
		if (task < 0 && task >5) cout << "Wrong task number!" << endl;
		else break;
	}
	////////////////////////////////////////TASK1///////////////////////////////////////////////
	Employer* P = new President("Stiv", "Jobs", Male, 24, 404, 51);
	Employer* M = new Manager("Alex", "Vergilium", Male, 38, 301, "Marketing");
	Employer* W = new Worker("Oleg", "Ivanov", "Electrical", Male, 42, "tech servise", 2136);
	///////////////////////////////////////TASK2////////////////////////////////////////////////
	Area* areas[4] = { new Rectangle(10,20),
					new Cicle(10),
					new RightTriangle(10,20),
					new Trapeze(10,20,5)};
	//////////////////////////////////////TASK3/////////////////////////////////////////////////
	List<int>* st = new Stack<int>();
	List<int>* que = new Queue<int>();
	/////////////////////////////////////TASK5/////////////////////////////////////////////////
	Equation* le;
	Equation* qe;
	///////////////////////////////MAIN SWITCH/////////////////////////////////////////////////
	switch (task) {
	case 1:
		P->print();
		M->print();
		W->print();
		break;
	case 2:
		cout << "Stack`s pushing: 10; 11;" << endl;
		st->push(10);
		st->push(11);
		cout << "Stack`s pop out: ";
		cout << st->pop() << "; ";
		cout << st->pop() << ";" << endl;

		cout << "Queue pushing: 10; 11; 12" << endl;
		que->push(10);
		que->push(11);
		que->push(12);

		cout << "Queue pop out: ";
		cout << que->pop() << "; ";
		cout << que->pop() << "; ";
		cout << que->pop() << ";" << endl;
		break;
	case 3:
		for (size_t i=0; i < 4; ++i) {
			cout << "Shape: " << areas[i]->getShape() << " area = " << areas[i]->area() << endl;
		}
	case 4:
		cout << "This task have not compleated!!! =(";
		break;
	case 5:
		float a, b, c, d;
		//===========================Line Equation===========================================
		cout << "Please enter values `a` and `b` from space for line equation " << endl;
		cin >> a >> b;
		le = new LineEquation(a, b);
		cout << "x = " << le->equationRoot()->at(0) << endl;
		//===========================Quadratic equation=====================================
		cout << "Please enter values `a`, `b`, `c` and `d` from space for quadratic equation " << endl;
		cin >> a >> b >> c >> d;
		qe = new QuadraticEquation(a, b, c, d);
		vector<float>* buf = qe->equationRoot();
		auto iter = buf->begin();
		if (buf) {
			cout << "Equation has " << buf->size() << "results." << endl;
			while (iter != buf->end()) {
				cout << "X= " << *iter << endl;
				++iter;
			}
		}
		else {
			cout << "This equetion have`t roots!" << endl;
		}
		break;
	}


	return 0;
}