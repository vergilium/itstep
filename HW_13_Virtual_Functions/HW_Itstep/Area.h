#pragma once
#include <string>

using namespace std;

const double PI = 3.14159265;
/* Создать абстрактный базовый класс с виртуальной
функцией — площадь Создать производные классы:
прямоугольник, круг, прямоугольный треугольник,
трапеция со своими функциями площади Для проверки определить массив ссылок на абстрактный класс,
которым присваиваются адреса различных объектов
Площадь трапеции: S=(a+b)h/2 */

class Area
{
	string m_lpShape;
public:
	Area(string shapeName) :m_lpShape(shapeName) {}
	string getShape() { return m_lpShape; }
	virtual double area() = 0;
};

class Rectangle : public Area {
	double m_a;
	double m_b;
public:
	Rectangle(double a, double b) :Area("Rectangle"), m_a(a), m_b(b){}
	double area() {
		return (m_a * m_b);
	}
};

class Cicle : public Area {
	double m_radius;
public:
	Cicle(double r) :Area("Cicle"), m_radius(r){}
	double area() {
		return PI * m_radius * m_radius;
	}
};

class RightTriangle : public Area {
	double m_a;
	double m_b;
public:
	RightTriangle(double a, double b) :Area("RightTriangle"), m_a(a), m_b(b) {}
	double area() {
		return (m_a * m_b) / 2;
	}
};

class Trapeze : public Area {
	double m_a;
	double m_b;
	double m_h;
public:
	Trapeze(double a, double b, double h) :Area("Trapeze"), m_a(a), m_b(b), m_h(h){}
	double area() {
		return ((m_a + m_b) * m_h) / 2;
	}
};