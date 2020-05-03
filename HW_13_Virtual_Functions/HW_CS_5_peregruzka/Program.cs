using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka
{
    class Program{
        static void Main(string[] args){

            LinearEquation Eq1 = new LinearEquation(10, 12, 5);
            LinearEquation Eq2 = new LinearEquation(5, 8, 9);
            LinearEquation.Calculate(Eq1, Eq2);

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
