#include "Trainee.h"
void Trainee::Send(string to, string message)
{
	classroom->Send(name, to, message);
}