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
			public Point m_pStartPosition { get; private set; }
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
			private int Width{ 
				get => m_iWidth; 
				set {
					if(value >= 3) m_iWidth = value;
					else throw new System.ArgumentException("Min value is '3'");
				}
			}
			public Triangle(int w, int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White) : base("Triangle", color, x, y) {
				Width = w;
			}

			public void Draw(char c) {
				Console.ForegroundColor = base.m_cColor;
				for(int i = 0; i <((m_iWidth % 2==0)?(m_iWidth / 2):(m_iWidth / 2)+1); i++) {
					Console.SetCursorPosition(base.m_pStartPosition.X+(m_iWidth / 2)-i, base.m_pStartPosition.Y+i);
					for(int j = 0; j <= i*2+ ((m_iWidth % 2 == 0) ? 1 : 0); j++) {
						Console.Write(c);
					}
					Console.WriteLine();
				}
			}
		
		}

		class Square : Shape, IDrawable {
			private int m_iWidth;
			private int Width {
				get => m_iWidth;
				set {
					if(value >= 3) m_iWidth = value;
					else throw new System.ArgumentException("Min value is '3'");
				}
			}

			public Square(int w, int x, int y, ConsoleColor color = ConsoleColor.White): base("Square", color, x, y) {
				Width = w;
			}

			public void Draw(char c) {
				Console.ForegroundColor = base.m_cColor;
				for(int i = 0; i < ((m_iWidth % 2 == 0) ? (m_iWidth / 2) : (m_iWidth / 2) + 1); i++) {
					Console.SetCursorPosition(base.m_pStartPosition.X, base.m_pStartPosition.Y + i);
					for(int j = 0; j <= m_iWidth; ++j) {
						Console.Write(c);
					}
					Console.WriteLine();
				}
			}

		}

		class Rectangle : Shape, IDrawable {
			private int m_iWidth;
			private int Width {
				get => m_iWidth;
				set {
					if(value >= 3) m_iWidth = value;
					else throw new System.ArgumentException("Min value is '3'");
				}
			}

			public Square(int w, int x, int y, ConsoleColor color = ConsoleColor.White) : base("Square", color, x, y) {
				Width = w;
			}

			public void Draw(char c) {
				Console.ForegroundColor = base.m_cColor;
				for(int i = 0; i < ((m_iWidth % 2 == 0) ? (m_iWidth / 2) : (m_iWidth / 2) + 1); i++) {
					Console.SetCursorPosition(base.m_pStartPosition.X, base.m_pStartPosition.Y + i);
					for(int j = 0; j <= m_iWidth; ++j) {
						Console.Write(c);
					}
					Console.WriteLine();
				}
			}

		}b  

	}
	
}
