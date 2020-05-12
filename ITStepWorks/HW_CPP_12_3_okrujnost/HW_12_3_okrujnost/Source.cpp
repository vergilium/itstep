#include <iostream>
#include <vector>

using namespace std;

class Point {
private:
	double x;
	double y;
public:
	Point(double x = 0, double y = 0) :x(x), y(y){}
	
	Point& operator=(const Point& obj) {
		x = obj.x;
		y = obj.y;
		return *this;
	}
	Point& operator+(const Point& obj) {
		x += obj.x;
		y += obj.y;
		return *this;
	}
	Point& operator/(const double val) {
		x /= val;
		y /= val;
		return *this;
	}
	double getx() {
		return x;
	}
	double gety() {
		return y;
	}
	void setxy(double x, double y) {
		this->x = x;
		this->y = y;
	}
	void setx(double x) {
		this->x = x;
	}
	void sety(double y) {
		this->y = y;
	}
	void show() {
		cout << x << ":" << y;
	}
};

class Square : public Point {
private:
	Point m_beginPoint;
	Point m_endPoint;
	double m_side;
	double m_diagonal;	
public:
	Square(Point beginP = { 0,0 }, Point endP = {0,0}) :m_beginPoint(beginP), m_endPoint(endP){
		m_side = abs(m_beginPoint.getx() + m_endPoint.getx());
		m_diagonal = m_side * sqrt(2);
	}

	Point getBegin() {
		return m_beginPoint;
	}

	Point getEnd() {
		return m_endPoint;
	}

	double getSideLenght() {
		return m_side;
	}

	double getDiagonal() {
		return m_diagonal;
	}

	void setSquare(Point begin, Point end) {
		m_beginPoint = begin;
		m_endPoint = end;
		m_side = abs(m_beginPoint.getx() + m_endPoint.getx());
		m_diagonal = m_side * sqrt(2);
	}

	void printSqr() {
		cout << "Begin point = "; m_beginPoint.show(); cout << endl;
		cout << "End point = "; m_endPoint.show(); cout << endl;
	}
};

class CicleInSquare : private Point, private Square {
private:
	Point m_center;
	Point m_endPoint;
	double m_diameter;
public:
	CicleInSquare(Point beginSqr = { 0,0 }, Point endSqr = {0,0}) : Square(beginSqr, endSqr) {
		m_center = (beginSqr + endSqr) / 2;
		m_endPoint.setxy(m_center.getx(), beginSqr.gety());
		m_diameter = beginSqr.getx() + endSqr.getx();
	}
	CicleInSquare(Square sqr) : Square(sqr) {
		m_center = (sqr.getBegin() + sqr.getEnd()) / 2;
		m_endPoint.setxy(m_center.getx(), sqr.getEnd().gety());
		m_diameter = sqr.getBegin().getx() + sqr.getEnd().getx();
	}

	Point getCenter() {
		return m_center;
	}
	Point getEndpoint() {
		return m_endPoint;
	}
	double getDiameter() {
		return m_diameter;
	}

	void setCicle(Square sqr) {
		this->setSquare(sqr.getBegin(), sqr.getEnd());
		m_center = (sqr.getBegin() + sqr.getEnd()) / 2;
		m_endPoint.setxy(m_center.getx(), sqr.getEnd().gety());
		m_diameter = sqr.getBegin().getx() + sqr.getEnd().getx();
	}

	void print() {
		cout << "Square coordinates:" << endl;
		this->printSqr();
		cout << "Cicle coordinates:" << endl;
		cout << "Center of cicle = "; m_center.show(); cout << endl;
		cout << "End point of cicle = "; m_endPoint.show(); cout << endl;
		cout << "Diameter of cicle = " << m_diameter << endl;
	}
};


int main() {
	Square sqr({ 0.25,0.25 }, { 2.5,2.5 });
	CicleInSquare cicle(sqr);
	cicle.print();

	return 0;
}