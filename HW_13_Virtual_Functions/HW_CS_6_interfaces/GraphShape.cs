using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW_CS_6_interfaces {
	namespace Task2 {
		interface IDrawable {
			void Draw(char с = '*');
		}
		abstract class Shape {
			public string m_sName { get; private set; }
			public ConsoleColor m_cColor { get; set; }
			private Point m_pStartPosition { get; set; }
			public Shape(string name, ConsoleColor color, Point stPos) {
				m_sName = name;
				m_cColor = color;
				m_pStartPosition = stPos;
			}
			public Shape(string name, ConsoleColor color, int x, int y) {
				m_sName = name;
				m_cColor = color;
				Move(x, y);
			}
			public virtual void Move(Point pos) {
				m_pStartPosition = pos;
			}
			public virtual void Move(int x, int y) {
				Point xy = new Point(x, y);
				m_pStartPosition = xy;
			}
		}

		class Triangle : Shape, IDrawable {

			private int m_iWidth;
			private int m_iHigth;
			private int Width{ 
				get => m_iWidth; 
				set {
					if(value >= 3) m_iWidth = value;
					else throw new System.ArgumentException("Min value is '3'");
				}
			}
			private int Higth{ 
				get=>m_iHigth;
				set {
					if(value >= 2) m_iHigth = value;
					else throw new System.ArgumentException("Min value is '2'");
				}
			}
			public Triangle(int w, int h, int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White) : base("Triangle", color, x, y) {
				Width = w;
				m_iHigth = h;
			}

			public void Draw(char с) {

				for(int i = 0; i < m_iHigth; i++) {
					for(int j = i; j < m_iWidth/2-1; j++) {
						Console.Write(" ");
					}
					for(int j = m_iWidth / 2-i; j < m_iWidth; j++) {
						Console.Write("*");
					}
					Console.WriteLine();
				}
			}
		}

	}
	
}
