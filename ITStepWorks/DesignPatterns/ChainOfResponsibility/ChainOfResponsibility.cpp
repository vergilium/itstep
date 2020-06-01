#include "Manager.h"
#include "LocalManager.h"
#include "LocalBranchManager.h"
#include "CEO.h"

#include<iostream>
using namespace std;

int main()
{
	Manager* vasya = new LocalManager();
	Manager* petya = new LocalBranchManager();
	Manager* fedya = new CEO();

	vasya->SetSuccessor(petya);
	petya->SetSuccessor(fedya);

	Claim first("About service","Daria Surgachova",500);
	vasya->Process(first);

	Claim second("About customer support", "Bill Medoff", 5000);
	vasya->Process(second);

	Claim third("About internet", "Fedor Evlanenko", 50000);
	vasya->Process(third);

	Claim fourth("About crash", "Misha Collins", 150000);
	vasya->Process(fourth);

	delete vasya;
	delete petya;
	delete fedya;

	return 0;
}