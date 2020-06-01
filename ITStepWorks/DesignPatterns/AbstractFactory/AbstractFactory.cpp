#include<iostream>
#include "Devices.h"
#include"PcConfigurator.h"
#include "PC.h"

using namespace std;

//Функция для печати информации о компьютере
void PrintPcConfiguration(const string& configName, PC* pc) {
	cout<<"\n======== "<<configName<<" ========\n";
	cout << "Box: " << pc->GetBox()->ToString()<<endl;
	cout<<"Main Board: "<<pc->GetMainBoard()->ToString()<<endl;
	cout << "Processor: " << pc->GetProcessor()->ToString()<<endl;
	cout<<"HDD: "<<pc->GetHdd()->ToString()<<endl;
	cout<<"Memory: "<<pc->GetMemory()->ToString()<<endl;
}

int main() {
	// настраиваем конфигурацию компьютера
	PcConfigurator* configurator = new PcConfigurator();
	PC* pc1 = new PC();

	// настроили конфигурацию на домашний компьютер
	configurator->SetPCFactory(new HomePcFactory());
	configurator->Configure(pc1);
	PrintPcConfiguration("Home configuration", pc1);
	delete pc1;
	
	PC* pc2 = new PC();
	// настроили конфигурацию на офисный компьютер
	configurator->SetPCFactory(new OfficePcFactory());
	configurator->Configure(pc2);
	PrintPcConfiguration("Office configuration", pc2);

	delete pc2;
	delete configurator;


	return 0;
}