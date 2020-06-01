#include "Book.h"



Book::Book(string pAuthor, string pTitle, string pStyle,int pNumCopies)
{
	author = pAuthor;
	title = pTitle;
	style = pStyle;
	SetNumberOfCopies(pNumCopies);
}


Book::~Book()
{
}

void Book::Show() const
{
	cout << "\n====================\n";
	cout << "\nInformation about book\n";
	cout << "Author:" << author << endl;
	cout << "Title:" << title << endl;
	cout << "Style:" << style << endl;
	cout << "Number of copies:" << GetNumberOfCopies();
	cout << "\n====================\n";
}
