#include "stdafx.h"

extern "C" int demo();  ///Пишет ошибку но компилит и работает

extern "C" __declspec(dllexport) int Test(int a, int b) {

	

	return demo() + a + b;
}
extern "C" __declspec(dllexport) void Foo(char* str) {
	
	std::cout << str;
}
