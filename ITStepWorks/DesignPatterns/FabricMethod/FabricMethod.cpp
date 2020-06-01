#include<iostream>
#include"Weapon.h"
using namespace std;

int main() {

	AbstractWeapon** weapons = new AbstractWeapon*[2];
	Point3D shotGunPt = { 10,10,10 };
	Point3D automaticPt = { 20,20,20 };
	Vector3D shotGunLc = { 80,80,80 };
	Vector3D automaticLc = { 120,120,120 };


	weapons[0] = new Shotgun();
	weapons[1] = new AutomaticWeapon();

	weapons[0]->SetLocation(shotGunPt);
	weapons[1]->SetLocation(automaticPt);

	weapons[0]->SetDirection(shotGunLc);
	weapons[1]->SetDirection(automaticLc);

	for (int i = 0;i < 2; i++) {
		AbstractBullet* bullet = weapons[i]->Shoot();
		bullet->HitTarget(NULL);
		delete bullet;
	}

	
	for (int i = 0;i < 2; i++) {
		delete weapons[i];
	}

	delete[]weapons;

	return 0;
} 