#include "stdafx.h"
#include "Observer.h"

ATOM MyRegWndClass(HINSTANCE hInst, LPCTSTR strClassName) {
	WNDCLASSEX wcex = { sizeof(WNDCLASSEX) };
	wcex.hInstance = hInst;
	wcex.lpszClassName = strClassName;
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	wcex.hCursor = LoadCursor(nullptr, IDC_ARROW);
	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = Observer::WndProc;
	return RegisterClassEx(&wcex);
}

INT WINAPI _tWinMain(HINSTANCE hInst, HINSTANCE, LPTSTR stdCmdLine, INT nCmdShow) {
	INITCOMMONCONTROLSEX initCtrls = {
		sizeof(INITCOMMONCONTROLSEX),
		ICC_ANIMATE_CLASS | ICC_WIN95_CLASSES
	};
	InitCommonControlsEx(&initCtrls);

	LPCTSTR className = _T("MyWndClassName");
	ATOM mainClass = MyRegWndClass(hInst, className);

#ifdef _DEBUG
	if (!mainClass) {
#ifdef  _UNICODE
		std::wstringstream ss;
#else
		std::streangstream ss;
#endif // _UNICODE
		ss << "Error register class, code =";
		ss << GetLastError();
		OutputDebugString(ss.str().c_str());
	}
#endif //_DEBUG

	HWND hWnd = CreateWindow(
		className,
		_T("Test Window"),
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT, 0,
		CW_USEDEFAULT, 0,
		GetDesktopWindow(), //nullptr
		nullptr,
		hInst,
		nullptr
	);
#ifdef _DEBUG

	if (!hWnd) {
#ifdef  _UNICODE
		std::wstringstream ss;
#else
		std::streangstream ss;
#endif // _UNICODE
		ss << "Error create Window, code =";
		ss << GetLastError();
		OutputDebugString(ss.str().c_str());
	}
#endif //_DEBUG

	if (nCmdShow == SW_NORMAL) {
		AnimateWindow(hWnd, 1000, AW_ACTIVATE | AW_SLIDE);
	}
	else {
		ShowWindow(hWnd, nCmdShow);
	}
	UpdateWindow(hWnd);

	MSG msg;
	
	while (GetMessage(&msg, nullptr, 0, 0)) {
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.wParam;
}