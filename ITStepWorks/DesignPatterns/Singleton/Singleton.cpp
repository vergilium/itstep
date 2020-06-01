#include<iostream>
#include<fstream>
#include<time.h>

using namespace std;

/*
* Класс журнала событий программы.
* Предназначение - запись событий в специальный текстовый файл.
* В программе может существовать только в одном экземпляре.
*/
class Logger {
private:
	// конструктор закрыт, чтобы нельзя было создать копию объекта в обход специальной функции
	Logger() {}
	// указатель на будущий объект логера
	static Logger* pObj;
public:
	// статическия функция-член для получения доступа к объекту логирования
	static Logger* GetInstance();
	// функция-член для записи строк в лог-файл
	void PutMessage(string message);
};

Logger* Logger::pObj = NULL;

// реализация функции-члена для получения доступа к объекту логирования
// Объект создается, если он не существовал. Если он существовал возвращается указатель на уже созданный объект
Logger* Logger::GetInstance() {
	if (!pObj) {
		pObj = new Logger();
	}
	return pObj;
}

// Реализация функции записи строк в лог-файл
void Logger::PutMessage(string message) {

	const time_t timer = time(NULL);
	ofstream fObj("logsingleton.txt", ios::app);
	if (!fObj) {

		cout << "\nError with file\n";
		exit(EXIT_FAILURE);
	}
	fObj << message.c_str() << "\t" << ctime(&timer) << endl;
}

int main() {
	// получаем доступ к объекту логирования
	Logger* pLogger = Logger::GetInstance();
	// записываем данные о логировании
	pLogger->PutMessage("This is first");
	pLogger->PutMessage("This is second");

	return 0;
}