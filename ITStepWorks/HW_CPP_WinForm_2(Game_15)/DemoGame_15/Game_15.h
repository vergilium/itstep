#pragma once
#include <random>
#include <algorithm>
#include <ctime>

struct Coord {
    int x;
    int y;
    Coord(int x, int y) : x(x), y(y) {
    }
};

class Game_15
{
private:

    int gameField[4][4];
    int zeroX;
    int zeroY;

public:

    Game_15();

    void initGame();
    int getValue(int x, int y);
    Coord getCoord(int value);
    Coord getZeroCoord();
    bool go(int value);
    bool isWin();
};

