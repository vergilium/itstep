using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_4_inheritance
{
    public struct POINT
    {
        public int x { get; set; }
        public int y { get; set; }

        public POINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }   
    public abstract class Shape
    {
        protected string m_name { get; private set; }
        public ConsoleColor m_color { get; private set; }
        private int m_currPoint { get; set; }
        private POINT[] m_points;

        public Shape(string name, ConsoleColor color, int pCount)
        {
            m_name = name;
            m_color = color;
            m_points = new POINT[pCount];
            m_currPoint = 0;
            //for(int i = 0; i<pLenght; ++i) 
            //{
            //    m_points[i] = points[i];
            //}
        }

        public virtual void Show()
        {
            Console.ForegroundColor = m_color;
            Console.WriteLine($"{m_name} have {m_points.Length} points.");
            Console.WriteLine("It is next:");
            foreach(POINT p in m_points)
            {
                Console.WriteLine($"[{p.x};{p.y}]");
            }
        }

        public int AddPoint(int x, int y)
        {

            if (m_currPoint < m_points.Length)
            {
                POINT p = new POINT(x, y);
                m_points[m_currPoint] = p;
                return ++m_currPoint;
            }
            else return -1;
        }

        public abstract double Space();

    }

    public class Triangle : Shape
    {
        public POINT m_stPosition { get; private set; }
        private bool m_visible;
        public Triangle(ConsoleColor color,  POINT stPos):base("Triangle", color, 3)
        {
            m_stPosition = stPos;
            m_visible = false;
        }

        public bool Visiple
        {
            set { m_visible = value; }
        }

        public override void Show()
        {
            if (m_visible == true) base.Show();
        }

        public override double Space()
        {
            double a, b, c;
            a=
        }
    }

    public class Rectangle : Shape
    {


    }

    class Program
    {
        static void Main(string[] args)
        {
            POINT st = new POINT(0, 0);

            ////////Triangle//////////////////////////////////////
            Triangle tr = new Triangle(ConsoleColor.Green, st);
            tr.Visiple = true;
            tr.AddPoint(0, 1);
            tr.AddPoint(1, 3);
            tr.AddPoint(2, 5);
            tr.Show();
            //////////////////////////////////////////////////////
            

            Console.ReadKey();

        }
    }
}
