#pragma once

// Интерфейс IMathematics, который описывает математические операции
class IMathematics {
public:
	virtual double Addition(double x, double y) = 0;
	virtual double Subtraction(double x, double y) = 0;
	virtual double Multiplication(double x, double y) = 0;
	virtual double Division(double x, double y) = 0;
};
