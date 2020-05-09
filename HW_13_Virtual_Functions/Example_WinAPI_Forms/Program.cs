using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoWindows;
using static DemoWindows.Windows;

namespace Example_WinAPI_Forms {
	class Program {
        [STAThread]
        static int Main(string[] args) {
            string className = "MyFirstWinApiWnd";
            IntPtr hInstance = GetModuleHandle(null);

            IntPtr atom = MyRegisterWndClass(className, hInstance);
            if (atom == IntPtr.Zero) {
                MessageBox(IntPtr.Zero, "Error", "Error", 1);
            }

            IntPtr hWnd = CreateWindowEx(
                0,
                //"MyFirstWinApiWnd",
                atom,
                "Моё окошечко",
                WS_OVERLAPPEDWINDOW,  //WS_SYSMENU | WS_BORDER | WS_CAPTION | WS_MINIMIZEBOX ,
                CS_USEDEFAULT, 0,
                CS_USEDEFAULT, 0,
                IntPtr.Zero,
                IntPtr.Zero,
                hInstance,
                IntPtr.Zero);

            if (hWnd == IntPtr.Zero) {
                uint errorCode = GetLastError();
                MessageBox(IntPtr.Zero, "Error", "Error", 1);
            }
            UpdateWindow(hWnd);
            ShowWindow(hWnd, SW_SHOW);

            MSG msg = new MSG();

            while (GetMessage(ref msg, IntPtr.Zero, 0, 0)) {
                TranslateMessage(ref msg);
                DispatchMessage(ref msg);
            }

            return (int)msg.wParam;
        }
    }
}
