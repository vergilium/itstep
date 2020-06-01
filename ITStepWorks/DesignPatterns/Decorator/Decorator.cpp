#include<iostream>
#include "Book.h"
#include "Borrowable.h"
#include "CD.h"

using namespace std;

int main()
{
	Book* book = new Book("Carol Aimes", "25 steps to success", "horror", 10);
	book->Show();

	CD* cd = new CD("Lou Abrams", "Binary Sound", "New Func", 100, 20);
	cd->Show();
	
	cout << "Let's give some books and cd's" << endl;

	Borrowable* borrowIt = new Borrowable(book);

	borrowIt->BorrowItem("Boris Gusev");
	borrowIt->BorrowItem("Tamara Loseva");

	borrowIt->Show();
	cout << endl;
	borrowIt->ReturnItem("Tamara Loseva");
	borrowIt->BorrowItem("Igor Grachev");
	borrowIt->Show();

	delete book;
	delete cd;

	return 0;
}