#pragma once
#include "stdafx.h"
class Observer
{
	HWND m_hWnd;
private:
	Observer(HWND hWnd) :m_hWnd(hWnd) {}
public:
	static LRESULT CALLBACK WndProc(HWND hWnd, UINT msg, WPARAM wParam, LPARAM lParam);

	void OnDestroy(HWND hWnd);
	void OnClose(HWND hWnd);
	BOOL OnCreate(HWND hWnd, LPCREATESTRUCT lpCS);
	void OnCommand(HWND hWnd, int id, HWND hWndCtrl, UINT nCodeNotifi);

};

