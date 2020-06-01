#include<iostream>
#include"RealCharacterFactory.h"
using namespace std;

int main()
{
	string document = "AFFCCDDZZZ";

	RealCharacterFactory charFactory(30);

	for (string::const_iterator first = document.begin(); first != document.end(); ++first) {
		const AbstractCharacter& characterValue = charFactory.GetChar(*first);
		characterValue.Show();
	}
	return 0;
}