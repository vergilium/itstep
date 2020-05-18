#pragma once

#include "stdafx.h"
#include "game_15.h"

class Observer{
	private:
		HWND m_hDlg;

		int m_nBtnSize = 100;
		int m_nBtnMargin = 10;
		int m_nBtnPadding = 20;
		Game_15 m_Game;

	public:
		Observer(HWND hDlg):m_hDlg(hDlg){}

		static BOOL CALLBACK DlgProc(HWND, UINT, WPARAM, LPARAM);

		BOOL OnInitDialog(HWND, HWND hwndFocus, LPARAM lParam);
		void OnCommand(HWND, INT Id, HWND hWndCtrl, UINT code);

};

