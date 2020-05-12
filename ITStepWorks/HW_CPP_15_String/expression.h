#pragma once
#include <iostream>
#include <string>
#include <stack>

using namespace std;

class Expression
{
	string m_lpExpression;
	bool m_prewDig = false;
public:
	Expression() {}
	Expression(string exp): m_lpExpression(exp){}
	void set(const string& exp) {
		m_lpExpression = exp;
	}

	double calc() {
		stack <char> st_oper;
		stack <int> st_dig;
		
		for (auto iter = m_lpExpression.begin(); iter != m_lpExpression.end(); ++iter) {
			if (isdigit(*iter)) {
				if (m_prewDig) {
					m_prewDig++;
					int buf = st_dig.top() * 10;
					st_dig.pop();
					buf += (*iter - 48);
					st_dig.push(buf);
				}
				else {
					st_dig.push(*iter - 48);
					m_prewDig = true;
				}
			}
			else {
				if (strchr("()", *iter)) {
					st_oper.push(*iter);
					m_prewDig = false;
				}
				else if(strchr("-+/*", *iter)){
					if (!st_dig.empty()) {
						int buf = st_dig.top();
						cout << buf, st_oper.top(),2;
					}
					st_oper.push(*iter);
					m_prewDig = false;
				}
				else
					throw "Incorrect expression!!!";
			}
		}
		return 0;
	}

};

