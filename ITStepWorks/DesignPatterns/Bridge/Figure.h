#pragma once
#include "PaintApi.h"

class Figure
{
protected:
	PaintApi* api;
public:

	Figure(PaintApi* pApi)
	{
		api = pApi;
	}

	virtual ~Figure()
	{
		if (api)
			delete api;
	}
	virtual void DrawFigure() const = 0;
};