// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"

extern "C" __declspec(dllexport) void __cdecl Test(char* str) {
    std::cout << str;
}

extern "C" __declspec(dllexport) int __stdcall demo_plus(int x, int y) {
    return x + y;
}

typedef struct MyStruct {
public:
    int x;
    int y;
    char arr[3];
} MyStruct;


extern "C" __declspec(dllexport) int __stdcall demo_struct(MyStruct& s) {
    std::cout << "x=" << s.x << "; y=" << s.y << ";";
    return s.x + s.y;
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

