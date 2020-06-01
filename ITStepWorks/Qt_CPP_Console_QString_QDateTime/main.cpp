#include <qtextstream.h>

extern "C" int main()
{
		QTextStream out(stdout);
		QString str1 = "love";
		//str1.append(" chess");
		//str1.prepend("I ");
		out << str1 << endl;
	
	
	return 0;
}
