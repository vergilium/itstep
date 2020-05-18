#include "Observer.h"

BOOL Observer::DlgProc(HWND hDlg, UINT msg, WPARAM wParam, LPARAM lParam)
{
	static Observer obj(hDlg);
	switch (msg)
	{
		HANDLE_MSG(hDlg, WM_COMMAND, obj.OnCommand);
		HANDLE_MSG(hDlg, WM_INITDIALOG, obj.OnInitDialog);
		
	}
	return 0;
}

BOOL Observer::OnInitDialog(HWND, HWND hwndFocus, LPARAM lParam)
{
	int clienGameSize = 2 * m_nBtnPadding + (m_nBtnMargin + m_nBtnSize) * 4;
	//TO DO: Set windowSize to gameSize

	TCHAR buffer[10];
	m_Game.initGame();
	for (int i = 0; i < 4; ++i) {
		for (int j = 0; j < 4; ++j) {
			int value = m_Game.getValue(j, i);
			if (!value)//zero
				continue;
			_itot_s(value, buffer, 10, 10);
			CreateWindow(
				_T("button"),
				buffer,
				WS_CHILD | WS_VISIBLE | BS_CENTER | BS_VCENTER,
				m_nBtnPadding + (m_nBtnMargin + m_nBtnSize) * j,
				m_nBtnPadding + (m_nBtnMargin + m_nBtnSize) * i,
				m_nBtnSize, m_nBtnSize,
				m_hDlg,
				(HMENU)(10000 + value),
				GetModuleHandle(nullptr),
				(LPVOID)value
			);		
		}
	}

	return TRUE;
}
void Observer::OnCommand(HWND, INT Id, HWND hWndCtrl, UINT code)
{
	if (Id > 10000 && Id < 10016) {
		int value = Id - 10000;
		if (m_Game.go(value)) {
			Coord coord = m_Game.getCoord(value);
			MoveWindow(hWndCtrl,
				m_nBtnPadding + (m_nBtnMargin + m_nBtnSize) * coord.x,
				m_nBtnPadding + (m_nBtnMargin + m_nBtnSize) * coord.y,
				m_nBtnSize, m_nBtnSize,
				TRUE);
			if (m_Game.isWin()) {
				MessageBox(m_hDlg, _T("You are WIN !!!"), _T(""), MB_OK);
			}
		}
		else {
			MessageBox(m_hDlg, _T("Error"), _T(""), MB_OK);
		}
	}

	switch (Id) {
	
	case IDCANCEL:
		EndDialog(m_hDlg, Id);
		break;
	}
}
