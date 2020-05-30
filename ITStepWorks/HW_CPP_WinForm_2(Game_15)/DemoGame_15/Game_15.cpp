#include "Game_15.h"


Game_15::Game_15()
{
	srand(time(0));
	for (int i = 0, n = 1; i < 4; ++i)
		for (int j = 0; j < 4; ++j, ++n)
			gameField[j][i] = n;

	gameField[3][3] = 0;
	zeroX = 3;
	zeroY = 3;
}

void Game_15::initGame()
{
	int move[4] = { -1,-1,-1,-1 };

	for (int i = 0; i < 10; ++i)
	{
		if ((zeroX - 1) >= 0 && zeroX - (zeroX - 1) == 1) { move[0] = getValue(zeroX - 1, zeroY); }
		if ((zeroX + 1) < 4 && (zeroX + 1) - zeroX == 1) { move[1] = getValue(zeroX + 1, zeroY); }
		if ((zeroY - 1) >= 0 && zeroY - (zeroY - 1) == 1) { move[2] = getValue(zeroX, zeroY - 1); }
		if ((zeroY + 1) < 4 && (zeroY + 1) - zeroY == 1) { move[3] = getValue(zeroX, zeroY + 1); }
		while (go(move[rand()%4]));
	}
	//Этот метод - задание на дом
	//Метод перемешивает данные, 
	//При этом игра должна собираться
}

int Game_15::getValue(int x, int y)
{
	return gameField[x][y];
}

Coord Game_15::getCoord(int value)
{
	for (int i = 0; i < 4; ++i)
		for (int j = 0; j < 4; ++j)
			if (gameField[j][i] == value)
				return Coord(j, i);

	return Coord(-1,-1);
}

Coord Game_15::getZeroCoord()
{
	return Coord(zeroX, zeroY);
}

bool Game_15::go(int value)
{
	Coord valueCoord = getCoord(value);
	if (abs(valueCoord.x - zeroX) + abs(valueCoord.y - zeroY) != 1) {
		return false;
	}
	gameField[zeroX][zeroY] = value;
	gameField[zeroX = valueCoord.x][zeroY = valueCoord.y] = 0;
	return true;
}

bool Game_15::isWin()
{
	//Это тоже домашнее задание
	for (int i = 0, n = 1; i < 4; ++i)
		for (int j = 0; j < 4; ++j, ++n)
			if(gameField[j][i] != (n<16?n:0))
			return false;
	return true;
}
