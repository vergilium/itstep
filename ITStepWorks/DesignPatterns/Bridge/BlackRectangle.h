#pragma once
#include "PaintApi.h"
#include <iostream>
using namespace std;

class BlackRectangle : public PaintApi
{
public:

	BlackRectangle()
	{
	}

	virtual ~BlackRectangle()
	{
	}
public:
	virtual void DrawRectangle(int x, int y, int endx, int endy)
	{
		cout << "Draw Black Rectangle\n x = " << x << " y = " << y << " endx = " << endx << " endy = " << endy<<endl;
	}
};

