#pragma once
#include <iostream>
using namespace System;

namespace ClassLibrary1 {
	public ref class SomeClass
	{
	public:
		static void DoWork() {
			Console::Write("Hello ");
			std::cout << "World";
		}
	};
}
