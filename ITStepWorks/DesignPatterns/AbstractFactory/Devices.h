#pragma once
#include<iostream>
#include<string>
using namespace std;

// абстрактный класс устройства
class Device {
public:
	virtual string ToString() = 0;
};

// абстрактный класс системного блока
class Box : public Device{

};

// абстрактный класс жесткого диска
class Hdd : public Device {

};

// абстрактный класс материнской платы
class MainBoard : public Device {
};

// абстрактный класс процессора
class Processor : public Device {
};

// абстрактный класс памяти
class Memory : public Device {
};

// конкретный класс процессора. Процессор AMD
class AmdProcessor : public Processor
{
public:
	string ToString()
	{
		return "AmdProcessor";
	}
};

// конкретный класс материнской платы. Материнская плата Asus
class AsusMainBord : public MainBoard
{
public:
	string ToString()
	{
		return "AsusMainBord";
	}
};
// конкретный класс системного блока. Серебряный блок серого цвета
class SilverBox : public Box
{
public: 
	string ToString()
	{
		return "SilverBox";
	}
};

// конкретный класс процессора. Intel процессор
class IntelProcessor : public Processor
{
public: 
	string ToString()
	{
		return "IntelProcessor";
	}
};

// конкретный класс жесткого диска. Жесткий диск LG
class LGHDD : public Hdd
{
public: 
	string ToString()
	{
		return "LG hdd";
	}
};

// конкретный класс материнской платы. Материнская плата MSI
class MSIMainBord : public MainBoard
{
public:
	string ToString()
	{
		return "MSIMainBord";
	}
};

class BlackBox : public Box
{
public: 
	string ToString()
	{
		return "BlackBox";
	}
};

// конкретный класс ОЗУ. ОЗУ DDR
class DdrMemory : public Memory
{
public: 
	string ToString()
	{
		return "DdrMemory";
	}
};

// конкретный класс жесткого диска. Жесткий диск Samsung
class SamsungHDD : public Hdd
{
public:
	string ToString()
	{
		return "Samsung hdd";
	}
};

// конкретный класс ОЗУ. ОЗУ DDR2
class Ddr2Memory : public Memory
{
public: 
	string ToString()
	{
		return "Ddr2Memory";
	}
};

