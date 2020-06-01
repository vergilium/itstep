#include "CD.h"



CD::CD(string pSinger, string pTitle, string pStyle, int pPlayTime, int pNumCopies)
{
	singer = pSinger;
	title = pTitle;
	style = pStyle;
	playtime = pPlayTime;
	SetNumberOfCopies(pNumCopies);
}


CD::~CD()
{
}

void CD::Show() const
{
	cout << "\n====================\n";
	cout << "\nInformation about CD disk\n";
	cout << "Singer:" << singer << endl;
	cout << "Title of CD:" << title << endl;
	cout << "Style of CD:" << style << endl;
	cout << "Duration of CD:" << playtime << endl;
	cout << "Number of copies:" << GetNumberOfCopies();
	cout << "\n====================\n";
}
