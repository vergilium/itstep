#pragma once
// класс Receiver класс телевизора
class TV
{
	// включен телевизор или нет
	bool on;
public:
	// включить телевизор
	void TurnOn() {
		std::cout << "\nTurn on TV\n";
		on = true;
	}
	// выключить телевизор
	void TurnOff() {
		std::cout << "\nTurn off TV\n";
		on = false;
	}
};
