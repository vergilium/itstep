#include <iostream>
#include "Rectangle.h"
#include "BlackRectangle.h"
#include "BlueRectangle.h"
using namespace std;

int main()
{

	
	Figure* blackRectangle = new Rectangle(10, 10, 100, 100, new BlackRectangle());
	Figure* blueRectangle = new Rectangle(20, 20, 200, 200, new BlueRectangle());
	
	blackRectangle->DrawFigure();
	blueRectangle->DrawFigure();

	delete blackRectangle;
	delete blueRectangle;

	return 0;
}