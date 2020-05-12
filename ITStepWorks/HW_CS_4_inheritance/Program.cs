using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW_CS_4_inheritance
{
    public abstract class Shape
    {
        protected string m_name { get; set; }
        public ConsoleColor m_color { get; private set; }
        private int m_currPoint { get; set; }
        protected Point[] m_points;

        public Shape(string name, ConsoleColor color, int pCount)
        {
            m_name = name;
            m_color = color;
            m_points = new Point[pCount];
            m_currPoint = 0;
        }

        public virtual void Show()
        {
            Console.ForegroundColor = m_color;
            Console.WriteLine($"{m_name} have {m_points.Length} points.");
            Console.WriteLine("It is next:");
            foreach(Point p in m_points)
            {
                Console.WriteLine($"[{p.X};{p.Y}]");
            }
        }

        public int AddPoint(int x, int y)
        {

            if (m_currPoint < m_points.Length)
            {
                Point p = new Point(x, y);
                m_points[m_currPoint] = p;
                return ++m_currPoint;
            }
            else return -1;

            
        }

        public static double DistanceBetweenTwoPoints(Point point1, Point point2)
        {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx* dx + dy* dy);
        }

        public abstract double Space();

    }
    /// <summary>
    /// Class Triangle
    /// </summary>
    public class Triangle : Shape
    {
        public Point m_stPosition { get; private set; }
        private bool m_visible;
        public Triangle(ConsoleColor color,  Point stPos):base("Triangle", color, 3)
        {
            m_stPosition = stPos;
            m_visible = false;
        }

        public bool Visiple
        {
            set { m_visible = value; }
        }

        public new void Show()
        {
            if (m_visible == true) base.Show();
        }

        public override double Space()
        {
            double a = DistanceBetweenTwoPoints(base.m_points[0], base.m_points[1]);
            double b = DistanceBetweenTwoPoints(base.m_points[1], base.m_points[2]);
            double c = DistanceBetweenTwoPoints(base.m_points[0], base.m_points[2]);
            double P = (a + b + c) / 2.0;

            return Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }
    }
    /// <summary>
    /// Class Rectangle
    /// </summary>
    /// 
    public class Rectangle : Shape
    {
        private const int numPoint = 4;
        public Rectangle(ConsoleColor color, Point stPos) : base("Rectangle", color, numPoint) { }

        public override double Space()
        {
            double a = DistanceBetweenTwoPoints(base.m_points[0], base.m_points[1]);
            double b = DistanceBetweenTwoPoints(base.m_points[1], base.m_points[2]);
            return a * b;
        }
    }
    /// <summary>
    /// Square
    /// </summary>
    /// 
    public class Square : Rectangle
    {
        public Square(ConsoleColor color, Point stPoint):base(color, stPoint)
        {
            base.m_name = "Square";
        }
    }

    public class Rhombus : Rectangle
    {
        public Rhombus(ConsoleColor color, Point stPoint) : base(color, stPoint)
        {
            base.m_name = "Rhombus";
        }

        public override double Space()
        {
            double d1 = DistanceBetweenTwoPoints(m_points[0], m_points[2]);
            double d2 = DistanceBetweenTwoPoints(m_points[1], m_points[3]);
            return (d1 * d2) / 2;
        }
    }

    public class Cycle : Shape
    {
        public Cycle(ConsoleColor color, Point stPos) : base("Cycle", color, 2) {}
        public override double Space()
        {
            double r = DistanceBetweenTwoPoints(m_points[0], m_points[1]);
            return Math.PI * r * r;
        }
    }

    public class Elipse : Shape 
    {
        public Elipse(ConsoleColor color, Point stPos) : base("Elipse", color, 3) { }
        public override double Space()
        {
            var a = DistanceBetweenTwoPoints(m_points[0], m_points[1]);
            var b = DistanceBetweenTwoPoints(m_points[0], m_points[2]);
            return Math.PI * a * b;
        }
    }

    public class Composite
    {
        private Shape[] m_composShape;
        private int m_shCount;
        public Composite(int maxShape)
        {
            m_composShape = new Shape[maxShape];
            m_shCount = 0;
        }

        public void AddShape(Shape shp)
        {
            if (m_shCount < m_composShape.Length) {
                m_composShape[m_shCount] = shp;
                m_shCount++;
            } else throw new IndexOutOfRangeException();
        }

        public void Print()
        {
            foreach(Shape el in m_composShape)
            {
                el?.Show();
                Console.WriteLine();
            }
        }

        public double Space()
        {
            double? spc = 0;
            for(int i =0; i<m_shCount; ++i)
            {
                spc += m_composShape[i]?.Space();
            }
            return (double)spc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point st = new Point(0, 0);

            ////////Triangle//////////////////////////////////////
            Triangle tr = new Triangle(ConsoleColor.Green, st);
            tr.Visiple = true;
            tr.AddPoint(1, 1);
            tr.AddPoint(3, 10);
            tr.AddPoint(2, 50);
            tr.Show();
            Console.WriteLine($"Spase of triange = {tr.Space():F}");
            //////Rectangle///////////////////////////////////////
            Rectangle rt = new Rectangle(ConsoleColor.White, st);
            rt.AddPoint(0, 0);
            rt.AddPoint(10, 10);
            rt.AddPoint(0, 20);
            rt.AddPoint(10, 20);
            rt.Show();
            Console.WriteLine($"Spase of rectangle = {rt.Space():F}");
            //////Square//////////////////////////////////////////
            Rectangle sq = new Square(ConsoleColor.Red, st);
            sq.AddPoint(0, 0);
            sq.AddPoint(0, 10);
            sq.AddPoint(10, 10);
            sq.AddPoint(10, 0);
            sq.Show();
            Console.WriteLine($"Space of square = {sq.Space()}");
            //////Rhombus////////////////////////////////////////
            Rectangle rb = new Rhombus(ConsoleColor.Blue, st);
            rb.AddPoint(0, 0);
            rb.AddPoint(-10, 10);
            rb.AddPoint(0, 10);
            rb.AddPoint(10, 0);
            rb.Show();
            Console.WriteLine($"Space of rhombus = {rb.Space()}");

            Cycle cy = new Cycle(ConsoleColor.Cyan, st);
            cy.AddPoint(0, 0);
            cy.AddPoint(0, 10);
            cy.Show();
            Console.WriteLine($"Space of cycle = {cy.Space()}");

            Shape el = new Elipse(ConsoleColor.DarkYellow, st);
            el.AddPoint(0, 0);
            el.AddPoint(0, 10);
            el.AddPoint(20, 0);
            el.Show();
            Console.WriteLine($"Space of Ellipse = {el.Space()}");

            Composite obj = new Composite(10);
            obj.AddShape(tr);
            obj.AddShape(rt);
            obj.AddShape(sq);
            obj.AddShape(rb);
            obj.AddShape(cy);
            obj.AddShape(el);

            obj.Print();

            Console.WriteLine($"Space of shape = {obj.Space()}");


            Console.ReadKey();

        }
    }
}
