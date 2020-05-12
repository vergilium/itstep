#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <winsqlite/winsqlite3.h>

#pragma comment(lib, "winsqlite3.lib")

#if defined _MSC_VER
#pragma comment(linker, "/EXPORT:callback=winsqlite._callback@16")
#endif

#define LINE_LIMIT		10

namespace storstd {
		class Storage{
	private:
		char* zErrMsg;
		sqlite3* db;
		int m_rc;
		const char* m_dbName;
		const char* m_SQLinit;
		static std::vector<std::string> m_SQLresponse;
	private:
		static int __stdcall callback(void* NotUsed, int argc, char** argv, char** azColName);

		bool dbOpen();

	public:
		explicit Storage(const char* db_name);
		/////Добавление новой записи в базу
		bool newRecord(std::string name, int money);
		/////Чтение в вывод данных с базы (Последние LINE_LIMIT)
		std::vector<std::string>& getRecords();
		
	};

}