#pragma once
#include<iostream>
#include "bullet.h"
using namespace std;

/*
* Класс абстрактного оружия
*/
class AbstractWeapon {
	protected:
		/*
		* Фабричный метод для создания пули.
		*/
		virtual AbstractBullet* CreateBullet() = 0;
	private:
		Point3D location;
		Vector3D direction;
		double caliber;
	public:
		/*
		* Текущее положение оружия
		*/
		Point3D GetLocation() {
			return location;
		}
		void SetLocation(const Point3D& newLocation) {
			location = newLocation;
		}
		/*
		* Направление оружия
		*/
		Vector3D GetDirection(){
			return direction;
		} 
		void SetDirection(const Vector3D& newDirection) {
			direction = newDirection;
		}
		
		/*
		* Калибр оружия
		*/
		double GetCaliber() {
			return caliber;
		}
		void SetCaliber(double newCaliber) {
			caliber = newCaliber;
		}

		/*
		* Метод, производящий выстрел.
		* Возвращает экзепмляр созданной пули.
		*/
		AbstractBullet* Shoot(){
			// создание объекта пули с помощью фабричного метода
			AbstractBullet* bullet = CreateBullet();
			// настройка пули на текущие параметры оружия
			bullet->SetCaliber(this->GetCaliber());
			bullet->SetLocation(this->GetLocation());
			bullet->SetDirection(this->GetDirection());
			// начать движение пули
			bullet->StartMovement();
			// возвратить экземпляр пули
			return bullet;
		}
};

/*
* Класс автоматического оружия.
*/
class AutomaticWeapon : public AbstractWeapon
{
	public:
		AutomaticWeapon(){
			this->SetCaliber(20);
		}
	protected:
		/*
		* Реализация фабричного метода.
		* Создает экземпляр пули,
		* специфический для текущего типа оружия.
		*/
		AbstractBullet* CreateBullet(){
			return new AutomaticBullet();
		}
};

/*
* Класс дробовика.
*/
class Shotgun : public AbstractWeapon
{
	public:
		Shotgun(){
			this->SetCaliber(50);
		}
	protected:
		/*
		* Реализация фабричного метода.
		* Создает экземпляр пули,
		* специфический для текущего типа оружия.
		*/
		AbstractBullet* CreateBullet()
		{
			return new ShotgunBullet();
		}
};