#pragma once

using namespace System;

namespace CPPCLRClassLibrary {
	class MyClass {

	};

	ref class MyRefClass {

	};
	public ref class CPPSomeClass
	{
	public:
		CPPSomeClass(String^ str) {
			MyClass* arr = new MyClass[100];
			Console::WriteLine(str);
			delete[] arr;

			MyRefClass^ mas = gcnew MyRefClass();
		}

		virtual String^ ToString() override {
			return "Hello C++";
		}
	};
}
