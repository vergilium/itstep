#pragma once
#include <string>
#include<iostream>
using namespace std;
#include "Classroom.h"

class Classroom;

class Trainee
{
private:
	string name;
	Classroom* classroom;
public:
	Trainee(string pName)
	{
		name = pName;
	}
public:
	string GetName() const
	{
		return name;
	}
	void SetName(string pName)
	{
		name = pName;
	}
	Classroom* GetClasroom() const
	{
		return classroom;
	}
	void SetClassroom(Classroom* pClassroom)
	{
		classroom = pClassroom;
	}
public:
	// Отсылка сообщения
	void Send(string to, string message);
	virtual void Receive(string from, string message)
	{
		cout << "\nMessage from " << from << " to " << name << " : " << message << endl;
	}
};

class MathClass : public Trainee
{
public:
	MathClass(string name) :Trainee(name)
	{}
	void Receivee(string from, string message)
	{
		cout << "\nMessage in Math class\n";
		Trainee::Receive(from, message);
	}
};
