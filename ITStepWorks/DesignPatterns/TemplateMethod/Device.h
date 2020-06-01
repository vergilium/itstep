#pragma once
class Device
{
public:

	Device()
	{
	}

	virtual ~Device()
	{
	}
public:
	virtual void MakeEngine() = 0;
	virtual void MakeWheels() = 0;
	virtual void MakeCabin() = 0;
	virtual void MakeWings() = 0;

	virtual void Assemble()
	{
		MakeEngine();
		MakeWheels();
		MakeCabin();
		MakeWings();
	}
};

