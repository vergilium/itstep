#pragma once
#include <map>

class Trainee;
using namespace std;

// класс Mediator
class AbstractClassroom
{
public:
	virtual void Send(string from, string to, string message) = 0;
	virtual void Register(Trainee* trainee) = 0;
};

// Это реализация ConcreteMediator
class Classroom :public AbstractClassroom
{
private:
	map<string, Trainee*> trainees;
public:
	void Register(Trainee* trainee);
	void Send(string from, string to, string message);
};
