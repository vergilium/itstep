using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW_CS_6_interfaces {

	
	class Program {
		static void Main(string[] args) {
			Task1.IPolygon[] pol = {
				new Task1.Triangle(10, 10, 10),
				new Task1.Square(25),
				new Task1.Rhombus(20, 10),
				new Task1.Rectungle(15,30),
				new Task1.Paralelogram(10,20,15),
				new Task1.Trapezoid(30, 10, 10),
				new Task1.Cicle(12),
				new Task1.Elips(12,6)
			};

			Task1.Composition obj = new Task1.Composition();
			for(int i = 0; i < pol.Length; ++i) {
				obj.addShape(pol[i]);
			}


			Task2.IDrawable[] objs = {
				new Task2.Triangle(9,10,10,ConsoleColor.Red),
				new Task2.Square(9, 5,5,ConsoleColor.Green),
				new Task2.Rectangle(9,10,30,20,ConsoleColor.Blue),
				new Task2.Rhombus(9,40,3,ConsoleColor.DarkYellow ),
				new Task2.Trapezoid(10, 50,10, ConsoleColor.DarkCyan)
			};
			foreach(var sh in objs) {
				sh.Draw();
			}
			Console.ReadKey();
		}
	}
}
 