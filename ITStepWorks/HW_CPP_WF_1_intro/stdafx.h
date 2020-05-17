#pragma once

#ifndef _WIN32_WINDOWS    // Allow use of features specific to Windows 98 or later.
#define _WIN32_WINDOWS 0x0410 // Change this to the appropriate value to target Windows Me or later.
#endif

#ifndef _WIN32_IE     // Allow use of features specific to IE 6.0 or later.
#define  _WIN32_IE 0x0600 // Change this to the appropriate value to target other versions of IE.
#endif

#include <Windows.h>
#include <windowsx.h>
#include <tchar.h>
#include <stralign.h>
#include <sstream>
#include <CommCtrl.h>
#include <mmstream.h>
#include <time.h>

#pragma comment(lib, "comctl32.lib");
#pragma comment(lib, "winmm.lib");

#pragma comment(linker,"\"/manifestdependency:type='win32' \
name='Microsoft.Windows.Common-Controls' version='6.0.0.0' \
processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")