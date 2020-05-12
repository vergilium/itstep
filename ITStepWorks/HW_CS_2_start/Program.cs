using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_2_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            const int M = 10;
            const int N = 10;

            Random rnd = new Random();

            int[] arr = new int[N];
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rnd.Next(-10, 10);
            }
            Console.WriteLine($"Random array on {arr.Length} elements");
            foreach (int n in arr)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();
            /////////////
            ///1. Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1
            ////////////
            var mas = Array.FindAll(arr, element => element != 0);
            Array.Copy(mas, arr, mas.Length);
            for (var i = mas.Length; i < arr.Length; ++i)
            {
                arr[i] = -1;
            }

            Console.WriteLine($"Replace 0 to -1 array on {arr.Length} elements");
            foreach (int n in arr)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();

            ////////////////
            ///2 Преобразовать массив так, чтобы сначала шли все
            ////////////////
            Array.Sort(arr);

            Console.WriteLine($"Sorted array");
            foreach (int n in arr)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();

            ///////////////////
            ///3 Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число
            ///встречается в массиве
            ///////////////////
            int num = 0;
            Console.WriteLine(@"Enter int number at -10 to 10");
            if (Int32.TryParse(Console.ReadLine(), out num) == false)
            {
                Console.WriteLine(@"Wrong number. By!");
            }
            else
            {
                int index = Array.IndexOf(arr, num);
                if (index >= 0)
                    Console.WriteLine($"Entered number at {index} possitions");
                else
                    Console.WriteLine("Number is out of array");
            }

            //////////////////
            ///4 В двумерном массиве порядка M на N поменяйте
            ///местами заданные столбцы
            //////////////////
            int[,] arr2 = new int[M, N];
            for (int i = 0; i < M; ++i)
                for (int j = 0; j < N; ++j)
                    arr2[i, j] = rnd.Next(-10, 10);

            int ind = 0;
            foreach (int n in arr2)
            {
                Console.Write(n + " ");
                if (++ind % 10 == 0)
                    Console.WriteLine();
            }
            int r1 = 0, r2 = 1;
            bool ifParse1, ifParse2;
            Console.WriteLine($"Enter rows for swap. With 0 for {M - 1}");
            ifParse1 = Int32.TryParse(Console.ReadLine(), out r1);
            ifParse2 = Int32.TryParse(Console.ReadLine(), out r2);
            if (ifParse1 == false || ifParse2 == false)
                Console.WriteLine(@"Wrong number. By!");
            else
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    arr[i] = arr2[r1, i];
                }
                Array.Copy(arr2, r2 * N, arr2, r1 * N, N);
                for (int i = 0; i < arr2.GetLength(0); ++i)
                {
                    arr2[r2, i] = arr[i];
                }
            }

            ind = 0;
            foreach (int n in arr2)
            {
                Console.Write(n + " ");
                if (++ind % 10 == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
