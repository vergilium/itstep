#pragma once
#include <iostream>
#include <string>

#define FILE_NAME		"rating.txt"
#define NUM_LINE		10

using namespace std;

bool WriteStat(string &, int);
int ReadStat(string *&);
