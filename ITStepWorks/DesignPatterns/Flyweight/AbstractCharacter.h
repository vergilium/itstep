#pragma once
class AbstractCharacter
{
public:
	AbstractCharacter();
	virtual ~AbstractCharacter();
	virtual void Show() const = 0;
protected:
	char symbol;
	int  width;
	int  height;
	int  ascent;
	int  descent;
	int  pointSize;
};

