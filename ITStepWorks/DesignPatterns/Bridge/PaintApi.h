#pragma once
class PaintApi
{
public:

	PaintApi()
	{
	}

	virtual ~PaintApi()
	{
	}
public:
	virtual void DrawRectangle(int x, int y, int endx, int endy) = 0;
};

