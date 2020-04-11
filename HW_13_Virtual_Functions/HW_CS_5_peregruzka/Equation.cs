using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka {
	class Equation {
        public struct AB {
            public int A { get; set; }
            public int B { get; set; }
            public AB(int a, int b) {
                A = a; B = b;
            }
            public static bool operator true(AB c) {
                return c.A != 0 || c.B != 0 ? true : false;
            }
            public static bool operator false(AB c) {
                return c.A == 0 && c.B == 0 ? true : false;
            }
            public static AB? Parse(String arg) {
                try {
                    int[] tmp = Array.ConvertAll(arg.Split(" ;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    //int[] tmp = arg.Split(" ;".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();
                    return new AB(tmp[0], tmp[1]);
                }
                catch {
                    Console.WriteLine("Wrong enter values! By!");
                    return null;
                }
            }
            public override string ToString() {
                return $"A = {A}; B = {B}";
            }
        }

        public class LinerEquation {
            private AB Eq1 { get; set; }
            private AB Eq2 { get; set; }
            public double x { get; private set; }
            public double y { get; private set; }
            LinerEquation(AB v1, AB v2) {
                Eq1 = v1;
                Eq2 = v2;
            }


        }
    }
}
