#include "Classroom.h"
#include "Trainee.h"
void Classroom::Register(Trainee* trainee)
{
	if (trainees.find(trainee->GetName()) == trainees.end())
	{
		trainees[trainee->GetName()] = trainee;
	}
	trainee->SetClassroom(this);
}
void Classroom::Send(string from, string to, string message)
{
	auto ptrTrainee = trainees.find(to);
	if (ptrTrainee != trainees.end())
	{
		(*ptrTrainee).second->Receive(from, message);
	}

}
