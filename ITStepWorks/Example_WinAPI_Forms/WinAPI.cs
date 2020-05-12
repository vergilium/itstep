using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoWindows {
    public delegate IntPtr MyWndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    public struct Point {
        public uint x;
        public uint y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MSG {
        public IntPtr hwnd;
        public uint message;
        public IntPtr wParam;
        public IntPtr lParam;
        public uint time;
        public Point pt;
        public uint lPrivate;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct WNDCLASSEX {
        [MarshalAs(UnmanagedType.U4)]
        public int cbSize;
        [MarshalAs(UnmanagedType.U4)]
        public uint style;
        public MyWndProcDelegate lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        public string lpszMenuName;
        public string lpszClassName;
        public IntPtr hIconSm;
    }

    class Windows {
        [DllImport("user32.dll")]
        public static extern void PostQuitMessage(int nExitCode);

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool GetMessage(
            ref MSG lpMsg,
            IntPtr hWnd,
            uint wMsgFilterMin,
            uint wMsgFilterMax
        );

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool TranslateMessage(ref MSG lpMsg);

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool DispatchMessage(ref MSG lpMsg);


        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyWindow(IntPtr hWnd);

        [DllImport("User32.dll")]
        public extern static int MessageBox(IntPtr hWnd, string msg, string caption, int flag);

        [DllImport("User32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public extern static bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("User32.dll")]
        public extern static IntPtr RegisterClassEx(ref WNDCLASSEX wndclassex);

        [DllImport("Kernel32.dll")]
        public extern static IntPtr GetModuleHandle(string moduleName);

        [DllImport("User32.dll", SetLastError = true, EntryPoint = "CreateWindowEx")]
        public extern static IntPtr CreateWindowEx(
            uint dwExStyle,
            //[MarshalAs(UnmanagedType.LPStr)]
            //string lpClassName,
            IntPtr atom,
            [MarshalAs(UnmanagedType.LPStr)]
            string lpWindowName,
            uint dwStyle,
            uint X,
            uint Y,
            uint nWidth,
            uint nHeight,
            IntPtr hWndParent,
            IntPtr hMenu,
            IntPtr hInstance,
            IntPtr lpParam);

        [DllImport("User32.dll")]
        public extern static IntPtr DefWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern uint GetLastError();

        [DllImport("user32.dll")]
        public static extern bool UpdateWindow(IntPtr hWnd);


        public static IntPtr MyWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam) {
            switch (msg) {
                case WM_CLOSE:
                    DestroyWindow(hWnd);
                    return IntPtr.Zero;
                case WM_DESTROY:
                    PostQuitMessage(0);
                    return IntPtr.Zero;
                default:
                    return DefWindowProc(hWnd, msg, wParam, lParam);

            }
        }

        public static IntPtr MyRegisterWndClass(string className, IntPtr hInstance) {
            WNDCLASSEX wcex = new WNDCLASSEX();
            wcex.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
            wcex.hInstance = hInstance;
            wcex.lpszClassName = className;
            wcex.style = CS_HREDRAW | CS_VREDRAW;
            wcex.hbrBackground = (IntPtr)(COLOR_WINDOW + 1);
            wcex.lpfnWndProc = MyWndProc;

            return RegisterClassEx(ref wcex);
        }



        public const uint CS_VREDRAW = 0x1;
        public const uint CS_HREDRAW = 0x2;
        public const uint COLOR_WINDOW = 5;
        public const uint CS_USEDEFAULT = 0x80000000;
        public const uint SW_SHOW = 5;
        public const uint WS_BORDER = 0x00800000;
        public const uint WS_CAPTION = 0x00C00000;
        public const uint WS_OVERLAPPED = 0x00000000;
        public const uint WS_MINIMIZEBOX = 0x00020000;
        public const uint WS_SYSMENU = 0x00080000;
        public const uint WS_THICKFRAME = 0x00040000;
        public const uint WS_OVERLAPPEDWINDOW = 0xCF0000;
        public const uint WM_DESTROY = 2;
        public const uint WM_PAINT = 0x0f;
        public const uint WM_CLOSE = 0x0010;
        public const uint WM_LBUTTONUP = 0x0202;
        public const uint WM_LBUTTONDBLCLK = 0x0203;
    }
}