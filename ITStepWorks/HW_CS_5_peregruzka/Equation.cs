using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka {
    class LinearEquation {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public LinearEquation(int a = 0, int b = 0, int c = 0) {
            A = a;
            B = b;
            C = c;
        }

        //public static void Parse(string s, ref LinearEquation le) {
        //    string[] words = s.Split(',', ' ');
        //    le.A = Convert.ToInt32(words[0]);
        //    le.B = Convert.ToInt32(words[1]);
        //    le.C = Convert.ToInt32(words[2]);
        //}

        public override string ToString() {
            return $"{A}*X + {B}*Y + {C} = 0";
        }

        public static void Calculate(LinearEquation LEq1, LinearEquation LEq2) {
            double D = LEq1.A * LEq2.B - LEq2.A * LEq1.B;
            if (D == 0)
                Console.WriteLine("Эта система не имеет решения ");
            else {
                double X = (LEq1.C * LEq2.B * (-1) - LEq2.C * LEq1.B * (-1)) / D;
                double Y = (LEq1.A * LEq2.C * (-1) - LEq2.A * LEq1.C * (-1)) / D;
                Console.WriteLine("Решением данных уравнений");
                Console.WriteLine(LEq1);
                Console.WriteLine(LEq2);
                Console.WriteLine($"является: X = {X}, Y = {Y}");
            }
        }
    }
}
