using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Unsafe
{
    class Program
    {
        unsafe static void foo()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            fixed (int* ptr = arr)
            {                
                for(int* p =ptr; p < ptr+10; ++p)
                {
                    Console.Write($"{ *p}; ");
                }
            }
        }
        static void Main(string[] args)
        {
            foo();
            int x;
            unsafe
            {
                int* p = &x;
                *p = 100;
            }
            Console.WriteLine(x);
        }
    }
}
