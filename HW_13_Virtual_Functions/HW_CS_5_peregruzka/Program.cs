using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka
{
    class Program{
        static void Main(string[] args){
            //AB? cfnt1 = new AB(),
            //    cfnt2 = new AB();
            //Console.WriteLine("Enter values 'A' and 'B' via space or ';'. And press 'Enter'");
            //cfnt1 = AB.Parse(Console.ReadLine());
            //Console.WriteLine("Enter values 'A' and 'B' via space or ';'. And press 'Enter'");
            //cfnt2 = AB.Parse(Console.ReadLine());

            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);

            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;

            Console.ReadKey();
        } 
    }
}
