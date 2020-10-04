using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Demo_20092020
{
    class Program
    {
        [DllImport("MyUnsafeLibrary", 
            CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        extern static void Foo(string str);


        [DllImport("MyUnsafeLibrary",
            CallingConvention = CallingConvention.Cdecl)]
        extern static int Test(int a, int b);

        [DllImport("MyUnsafeLibrary",
            CallingConvention = CallingConvention.Cdecl)]
        extern static int demo();

        [DllImport("AsmLibrary",
            CallingConvention = CallingConvention.Cdecl)]
        extern static int plus(int a, int b);

        [DllImport("AsmLibrary", EntryPoint ="demo",
            CallingConvention = CallingConvention.Cdecl)]
        extern static int DEMO();


        static void Main(string[] args)
        {
            int y = DEMO();
            int z = plus(100, 200);

            SomeClass.DoWork();

            int x = demo();

            int res = Test(10, 20);
            Foo(res.ToString());
        }
    }
}
