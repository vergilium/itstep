#include "Observer.h"
LRESULT CALLBACK Observer::WndProc(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam) {
	static Observer obj(hWnd);
	switch (msg) {
		HANDLE_MSG(hWnd, WM_COMMAND, obj.OnCommand);
		HANDLE_MSG(hWnd, WM_CREATE, obj.OnCreate);
		HANDLE_MSG(hWnd, WM_CLOSE, obj.OnClose);
		HANDLE_MSG(hWnd, WM_DESTROY, obj.OnDestroy);
	}
	return DefWindowProc(hWnd, msg, wParam, lParam);
}

BOOL Observer::OnCreate(HWND hWnd, LPCREATESTRUCT lpCS) {
	return true;
}

void Observer::OnCommand(HWND hWnd, int id, HWND hWndCtrl, UINT nCodeNotifi) {
	switch (id) {

	}
}

void Observer::OnDestroy(HWND hWnd) {
	PostQuitMessage(0);
}

void Observer::OnClose(HWND hWnd) {
	if(IDYES == MessageBox(hWnd,
		_T("Do you want to close?"),
		_T(""),
		MB_YESNO | MB_ICONQUESTION | MB_DEFBUTTON2))
	DestroyWindow(hWnd);
}