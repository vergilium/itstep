#include <iostream>
#include <string>

#include "expression.h"

using namespace std;

int main(){
	Expression exp;
	char str;
	//cout << "Enter expression: " << endl;
	//getline(cin, str);
	exp.set("(2+2)*450+1");
	exp.calc();


}