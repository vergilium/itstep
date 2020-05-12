using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_5_peregruzka
{
    public class Fraction
    {
        #region fields and properties
        public int ch { get; private set; }
        public int zn { get; private set; }
        public int this[int i]
        {
            get{
                switch (i){
                    case 0: return ch;
                    case 1: return zn;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set{
                switch (i){
                    case 0: ch = value; break;
                    case 1: zn = value;  break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
        #endregion
        public Fraction(int c, int z) { ch = c; zn = z; }
        private int nod(int a, int b){
            while (a != b){
                if (a > b){
                    a -= b;
                }
                if (b > a){
                    b -= a;
                }
            }
            return a;
        }

        #region ariphmetic operations
        public static Fraction operator -(Fraction a) {
            return new Fraction(-a.ch, a.zn);
        }
        public static Fraction operator +(Fraction a) {
            return new Fraction(a.ch, a.zn);
        }
        public static Fraction operator +(Fraction a, Fraction b) {
            return new Fraction(a.ch * b.zn + b.ch * a.zn, a.zn * b.zn);
        }
        public static Fraction operator -(Fraction a, Fraction b) {
            return new Fraction(a.ch * b.zn - b.ch * a.zn, a.zn * b.zn);
        }
        public static Fraction operator *(Fraction a, Fraction b) {
            return new Fraction(a.ch * b.ch, a.zn * b.zn);
        }
        public static Fraction operator /(Fraction a, Fraction b) {
            return new Fraction(a.ch * b.zn, a.zn * b.ch);
        }
        public static Fraction operator +(Fraction a, int x) {
            return new Fraction(a.ch + x * a.zn, a.zn);
        }
        public static Fraction operator +(int x, Fraction a) {
            return new Fraction(a.ch + x * a.zn, a.zn);
        }
        public static Fraction operator +(Fraction a, double x) {
            return new Fraction(a.ch + (int)x * a.zn, a.zn);
        }
        public static Fraction operator *(Fraction a, int x) {
            return new Fraction((a.ch * x), a.zn);
        }
        public static Fraction operator *(int x, Fraction a) {
            return new Fraction((a.ch * x), a.zn);
        }
        public static Fraction operator ++(Fraction a) {
            return new Fraction(a.ch + 1, a.zn);
        }
        public static Fraction operator --(Fraction a) {
            return new Fraction(a.ch - 1, a.zn);
        }
		#endregion

		#region Logical operation
		public static bool operator >(Fraction a, Fraction b) {
            return a.ch * b.zn > b.ch * a.zn;
        }
        public static bool operator <(Fraction a, Fraction b) {
            return a.ch * b.zn < b.ch * a.zn;
        }
        public static bool operator >=(Fraction a, Fraction b) {
            return a.ch * b.zn >= b.ch * a.zn;
        }
        public static bool operator <=(Fraction a, Fraction b) {
            return a.ch * b.zn <= b.ch * a.zn;
        }
        public static bool operator ==(Fraction a, Fraction b) {
            return a.ch * b.zn == b.ch * a.zn;
        }
        public static bool operator !=(Fraction a, Fraction b) {
            return a.ch * b.zn != b.ch * a.zn;
        }
        public static explicit operator int(Fraction a) {
            return a.ch / a.zn;
        }
        public static implicit operator double(Fraction a) {
            return a.ch / (double)a.zn;
        }
        public static bool operator true(Fraction a) {
            return a.ch < a.zn;
        }
        public static bool operator false(Fraction a) {
            return a.ch > a.zn;
        }
        #endregion

        public double ToReal() {
            return ch / zn; 
        }
        public override string ToString() {
            return ch < zn ? $"{ch}/{zn}" : $"{ch / zn}+{ch % zn}/{zn}";
        }
        public override bool Equals(object obj) {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode() {
            return this.ToString().GetHashCode();
        }
    }
}
