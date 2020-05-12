using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using CPPCLRClassLibrary;

namespace Demo_dll_CS_EXE {

	class Program {
		[StructLayout(LayoutKind.Sequential)]
		public class SystemTime {
			public ushort wYear;
			public ushort wMonth;
			public ushort wDayOfWeek;
			public ushort wDay;
			public ushort wHour;
			public ushort wMinute;
			public ushort wSecond;
			public ushort wMilliseconds;
		}

		[DllImport("Kernel32")]
		internal static extern void GetLocalTime([In, Out] SystemTime st);

		[StructLayout(LayoutKind.Sequential)] //По умолчанию
		public class MyStruct {
			public int x;
			public int y;
		}
		[DllImport("MyLibraryCPP")]
		extern static int demo_struct(MyStruct s);

		[DllImport("MyLibraryCPP", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test", CharSet = CharSet.Unicode)]
		extern static void TestFromDll(string str);
		[DllImport("MyLibraryCPP")]
		extern static int demo_plus(int x, int y);
		static void Main(string[] args) {
			//SomeClass obj = SomeClass{nameof = "Vasya", 14);
			SystemTime st = new SystemTime();
			GetLocalTime(st);
			Console.WriteLine(demo_struct(new MyStruct { x = 100, y = 200 }));
			//exitwindowsex для домашки

			CPPSomeClass sc = new CPPSomeClass("test");
			Console.WriteLine(sc.ToString());

			Console.ReadKey();
		}
	}
}
