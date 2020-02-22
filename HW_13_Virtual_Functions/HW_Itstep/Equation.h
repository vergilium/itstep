#pragma once
#include <vector>
class Equation
{
public:
	virtual std::vector<float>* equationRoot() = 0;
};

class LineEquation : public Equation {
	float m_a, m_b;
	std::vector<float> m_x;
public:
	LineEquation(float a, float b): m_a(a), m_b(b) {}
	std::vector<float>* equationRoot();

};


class QuadraticEquation : public Equation {
	float m_a, m_b, m_c, m_d;
	float m_D;
	std::vector<float> mp_x;
public:
	QuadraticEquation(float a, float b, float c, float d) : m_a(a), m_b(b), m_c(c), m_d(d), m_D(0) { mp_x.clear(); }
	std::vector<float>* equationRoot();

};
