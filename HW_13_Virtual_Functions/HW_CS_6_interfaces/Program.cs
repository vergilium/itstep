using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using HW_CS_6_interfaces.Task1;

namespace HW_CS_6_interfaces {

	
	class Program {
		static void Main(string[] args) {
			IPolygon[] pol = {
				new Triangle(10, 10, 10),
				new Square(25),
				new Rhombus(20, 10),
				new Rectungle(15,30),
				new Paralelogram(10,20,15),
				new Trapezoid(30, 10, 10),
				new Cicle(12),
				new Elips(12,6)
			};

			Composition obj = new Composition();
			for(int i = 0; i < pol.Length; ++i) {
				obj.addShape(pol[i]);
			}


			Task2.IDrawable[] objs = {
				new Task2.Triangle(9,10,10,ConsoleColor.Red),
				new Task2.Square(9, 5,5,ConsoleColor.Green)
			};
			foreach(var sh in objs) {
				sh.Draw();
			}
			Console.ReadKey();
		}
	}
}
 