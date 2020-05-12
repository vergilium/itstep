#include "storage.h"

storstd::Storage::Storage(const char* db_name) :zErrMsg(nullptr), m_dbName(db_name), m_rc(0), db(nullptr), m_SQLinit("CREATE TABLE IF NOT EXISTS stat (id INTEGER PRIMARY KEY AUTOINCREMENT, pName TEXT, money INTEGER )") {}
std::vector<std::string> storstd::Storage::m_SQLresponse;

int __stdcall storstd::Storage::callback(void* NotUsed, int argc, char** argv, char** azColName) {
	int i;
	for (i = 0; i < argc; i++) {
		m_SQLresponse.push_back(argv[i]);
	}
	return 0;
}

bool storstd::Storage::dbOpen() {
	m_rc = sqlite3_open(m_dbName, &db);
	m_rc = sqlite3_exec(db, m_SQLinit, NULL, 0, &zErrMsg);
	if (m_rc != 0) {
		return false;
	}
	return true;
}

bool storstd::Storage::newRecord(std::string name, int money) {
	std::string sql = "INSERT INTO stat (pName, money) VALUES ('" + name + "', " + std::to_string(money) + ")";
	if (dbOpen()) {
		m_rc = sqlite3_exec(db, sql.c_str(), 0, 0, &zErrMsg);
		sqlite3_close(db);
		if (m_rc != 0)
			return false;
	}
	return true;
}

std::vector<std::string>& storstd::Storage::getRecords() {
	std::string sql = "SELECT pName, money FROM stat ORDER BY id LIMIT " + std::to_string(LINE_LIMIT);
	if (dbOpen()) {
		m_SQLresponse.clear();
		m_rc = sqlite3_exec(db, sql.c_str(), callback, 0, &zErrMsg);
		sqlite3_close(db);
		if (m_rc != 0)
			m_SQLresponse.clear();
	}
	return m_SQLresponse;
}