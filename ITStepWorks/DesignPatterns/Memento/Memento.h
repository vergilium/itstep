#pragma once
#include <string>
using namespace std;
// класс Memento
class Memento
{
private:
	string name;
	string surname;
	int age;
public:
	Memento(string pName, string pSurname, int pAge)
	{
		name = pName;
		surname = pSurname;
		age = pAge;
	}

	string GetName() const
	{
		return name;
	}
	void SetName(string pName)
	{
		name = pName;
	}

	string GetSurname() const
	{
		return surname;
	}
	void SetSurname(string pSurname)
	{
		surname = pSurname;
	}
	int GetAge() const
	{
		return age;
	}
	void SetAge(int pAge)
	{
		age = pAge;
	}
};


