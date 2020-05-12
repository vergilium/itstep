using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka
{
    public class Complex
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public readonly int i2 = -1;

        public Complex(int x, int y){
            this.x = x;
            this.y = y;
        }

        public static Complex operator +(Complex c1, Complex c2){
            return new Complex ((c1.x + c2.x), (c1.y + c2.y));
        }
        public static Complex operator +(Complex c, int v)
        {
            return new Complex((c.x + v), (c.y));
        }
        public static Complex operator -(Complex c1, Complex c2){
            return new Complex((c1.x - c2.x), (c1.y - c2.y));
        }
        public static Complex operator -(Complex c, int v)
        {
            return new Complex((c.x - v), (c.y));
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex((c1.x*c2.x - c1.y * c2.y), (c1.y * c2.x + c1.x * c2.y));
        }
        public static Complex operator *(Complex c, int v)
        {
            return new Complex((c.x * v), (c.y));
        }
        public static Complex operator *(int v, Complex c)
        {
            return new Complex((c.x * v), (c.y));
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(((c1.x * c2.x + c1.y * c2.y)/(c2.x*c2.x + c2.y*c2.y)), ((c1.y * c2.x - c1.x * c2.y)/ (c2.x * c2.x + c2.y * c2.y)));
        }
        public static Complex operator /(Complex c, int v)
        {
            return new Complex((c.x / v), (c.y / v));
        }
        public static Complex operator /(int v, Complex c)
        {
            return new Complex(((c.x * v) / (c.x * v + c.y * v)), ((c.y * v) / (c.x * v + c.y * v)));
        }

        public override string ToString()
        {
            return $"({x}+{y}i)";
        }
    }
}
