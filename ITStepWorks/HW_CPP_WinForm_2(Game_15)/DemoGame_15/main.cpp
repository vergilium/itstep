#include "stdafx.h"
#include "Observer.h"
#include "resource.h"

INT WINAPI _tWinMain(HINSTANCE hInst, HINSTANCE, LPTSTR strCommandLine, INT nCmdShow) {

	INITCOMMONCONTROLSEX initCtls = {
		sizeof(INITCOMMONCONTROLSEX),
		ICC_WIN95_CLASSES
	};
	InitCommonControlsEx(&initCtls);

	if (IDOK == DialogBox(
		hInst,
		MAKEINTRESOURCE(IDD_DIALOG1),
		nullptr,
		Observer::DlgProc)) {
		
		//TODO: User press OK
	}
	else {
		//
	}
	return 0;
}
