#pragma once
#include<iostream>
using namespace std;

/*
* Точка в трехмерном пространстве.
* Используется для определения положения.
*/
struct Point3D {
	int X;
	int Y;
	int Z;
};

/*
* Вектор в трехмерном пространстве.
* Используется для определения направления.
*/
struct Vector3D {
	int X;
	int Y;
	int Z;
};

/*
* Класс абстрактной пули.
*/
class AbstractBullet
{
	private:
		Point3D location;
		Vector3D direction;
		double caliber;
public:
	/*
	* Текущее положение пули
	*/
	Point3D GetLocation() {
		return location;
	}
	void SetLocation(const Point3D& newLocation) {
		location = newLocation;
	}
	/*
	* Направление пули
	*/
	Vector3D GetDirection() {
		return direction;
	}
	void SetDirection(const Vector3D& newDirection) {
		direction = newDirection;
	}

	/*
	* Калибр пули
	*/
	double GetCaliber() {
		return caliber;
	}
	void SetCaliber(double newCaliber) {
		caliber = newCaliber;
	}

	/*
	* Начало движения пули.
	*/
	void StartMovement()
	{
		// Реализация начала движения
	}
	/*
	* Метод поражения цели.
	* Так как разные типы пуль поражают цель по-разному,
	* то метод должен быть реализован в подклассах.
	*/
	virtual void HitTarget(void* target) = 0;
	/*
	* Метод, реализующий движение пули.
	* Так как разные типы пуль имеют разную траекторию движения,
	* то метод должен быть реализован в подклассах.
	*/
	virtual void Movement() = 0;
};

/*
* Класс пули для автоматического оружия.
*/
class AutomaticBullet : public AbstractBullet
{
	public:
		void HitTarget(void* target){
			// реализация поражения цели target
			cout << "Hit by automatic bullet\n";
		}
		void Movement(){
			// реализация алгоритма движения пули
		}
};

/*
* Класс пули для дробовика.
*/
class ShotgunBullet : public AbstractBullet
{
	public:
		void HitTarget(void* target){
			// реализация поражения цели target
			cout << "Hit by shotgun bullet\n";
		}
		void Movement(){
			// реализация алгоритма движения пули
		}
};