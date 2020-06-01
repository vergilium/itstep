#pragma once
#include<iostream>
#include"IMath.h"
using namespace std;

// класс, чьи операции будут скрыты
class Mathematics : public IMathematics
{
public:
	double Addition(double x, double y) { return x + y; }

	double Subtraction(double x, double y) { return x - y; }

	double Multiplication(double x, double y) { return x * y; }

	double Division(double x, double y) { return x / y; }

};
