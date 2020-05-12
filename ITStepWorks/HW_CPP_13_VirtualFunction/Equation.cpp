#include "Equation.h"

std::vector<float>* LineEquation::equationRoot() {
	m_x.push_back(m_b / m_a);
	return &m_x;
}

std::vector<float>* QuadraticEquation::equationRoot() {
	m_D = m_b * m_b - 4 * m_a * (m_c - m_d);
	if (m_D > 0) {
		mp_x.push_back((-m_b - sqrt(m_D)) / (2. * m_a));
		mp_x.push_back((-m_b + sqrt(m_D)) / (2. * m_a));
	}
	else {
		if (m_D == 0) {
			mp_x.push_back((-m_b) / (2 * m_a));
		}
		else {
			return nullptr;
		}
	}
	return &mp_x;
}