using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_1_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////
            ///Задание 1.
            /////////////////////////////////////////////////////////
            
            int a=0, b= 0, c= 0;
            int c_Height=0, c_Lenght=0, buf_a, buf_b;
            try { 
                Console.Write("Enter sides of rectangle (mm)\nA = ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nB = ");
                b = Int32.Parse(Console.ReadLine());
                Console.Write("Enter side of rectangle (mm)\nC = ");
                c = Int32.Parse(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(e.GetHashCode());
            }
            if(c > a || c > b){
                Console.WriteLine("Rectangle`s big. It does not fit into a rectangle");
                Environment.Exit(0);
            }
            buf_a = a; buf_b = b;
            while(a >= c) {
                a -= c;
                c_Height++;
            }
            while(b >= c){
                b -= c;
                c_Lenght++;
            }
            Console.WriteLine("Squares include in rectangle = " + (c_Height * c_Lenght) + " peases");
            Console.WriteLine("Reminder of rectangle = " + ((a*buf_b + b*buf_a)-(a*b)) + " mm2");
            
            /////////////////////////////////////////////////////////////////////////////////
            ///Задание 2.
            ////////////////////////////////////////////////////////////////////////////////
            
            float startMoney = 0F, percentsMonth = 0F, needResult = 0F, result = 1F;
            int c_monts = 0;
            try
            {
                Console.WriteLine("Enter initial contribution");
                startMoney = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter initial percent/month");
                percentsMonth = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter weel have neaded result");
                needResult = float.Parse(Console.ReadLine());
            }catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(e.GetHashCode());
            }
            if (percentsMonth > 0 && percentsMonth < 25)
            {
                while (startMoney * result < needResult)
                {
                    ++c_monts;
                    result *= 1 + ((percentsMonth * 31) / (365 * 100));
                }
                Console.WriteLine("You will have neaded result after " + c_monts + " month(s)");
                Console.WriteLine("You will get " + (startMoney * result) + "$");
            }
            else
            {
                Console.WriteLine("Percentage should be no more than 25 and not equal zero!");
            }
            
            //////////////////////////////////////////////////////////////////////////////////
            ///Задание 3.
            /////////////////////////////////////////////////////////////////////////////////
            
            int a = 0, b = 0;
            try
            {
                Console.WriteLine("Enter A");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter B");
                b = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Environment.Exit(e.GetHashCode());
            }

            while(b >= a)
            {
                for (int j = 1; j < a; ++j)
                {
                    Console.Write(a);
                }
                Console.WriteLine(a++);
            }
            
            //////////////////////////////////////////////////////////////////////////////////
            ///Задание 4.
            /////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter number > 0");
            Console.WriteLine(Console.ReadLine().Reverse().ToArray());
            /////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
