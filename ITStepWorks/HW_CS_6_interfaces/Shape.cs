using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CS_6_interfaces {

	namespace Task1 {
		abstract class Shape {
			public virtual double _space { get; }
			public virtual double _perimeter { get; }
		}
		/// <summary>
		/// Triangle
		/// </summary>
		class Triangle : Shape, IPolygon {
			private double A, B, C;
			public Triangle(double a, double b, double c) {
				if((a + b <= c) || (a + c <= b) || (b + c <= a))
					throw new System.ArgumentException("This triangle does`t exist");
				else {
					A = a; B = b; C = c;
				}
			}
			public override double _space {
				get {
					double P = (A + B + C) / 2.0;
					return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
				}
			}
			public override double _perimeter {
				get {
					return A + B + C;
				}
			}
			public double _hight {
				get {
					double p = (A + B + C) / 2;
					return (2 * Math.Sqrt(p * (p - A) * (p - B) * (p - C)) / A);
				}
			}
			public double _base { get => A; }
			public double _angle { get; set; }
			public uint _nSides { get => 3; }
			public double[] _lSides {
				get {
					double[] temp = { A, B, C };
					return temp;
				}
			}
		}
		/// <summary>
		/// Square
		/// </summary>
		/// 
		class Square : Shape, IPolygon {
			private double A;
			public Square(double a) {
				A = a;
			}
			public override double _space => A * A;
			public override double _perimeter => A * 4.0;
			public double _hight => A;
			public double _base => A;
			public double _angle { get; set; }
			public uint _nSides => 4;
			public double[] _lSides {
				get {
					double[] temp = { A, A, A, A };
					return temp;
				}
			}
		}
		/// <summary>
		/// Rhombus
		/// </summary>
		class Rhombus : Shape, IPolygon {
			public double A, H;
			public Rhombus(double a, double h) {
				A = a; H = h;
			}
			public override double _space => A * H;
			public override double _perimeter => A * 4;
			public double _hight => H;
			public double _base => A;
			public double _angle { get; set; }
			public uint _nSides => 4;
			public double[] _lSides {
				get {
					double[] temp = { A, A, A, A };
					return temp;
				}
			}
		}
		/// <summary>
		/// Rectungle
		/// </summary>
		/// 
		class Rectungle : Shape, IPolygon {
			double A, B;
			public Rectungle(double a, double b) {
				A = a; B = b;
			}
			public override double _space => A * B;
			public override double _perimeter => A + B * 2.0;
			public double _hight => B;
			public double _base => A;
			public double _angle { get; set; }
			public uint _nSides => 4;
			public double[] _lSides {
				get {
					double[] temp = { A, B, A, B };
					return temp;
				}
			}
		}
		/// <summary>
		/// Paralelogram
		/// </summary>
		/// 
		class Paralelogram : Shape, IPolygon {
			public double A, B, H;
			public Paralelogram(double a, double b, double h) {
				A = a; B = b; H = h;
			}
			public override double _space => A * H;
			public override double _perimeter => A + B * 2.0;
			public double _hight => H;

			public double _base => A;

			public double _angle { get; set; }

			public uint _nSides => 4;

			public double[] _lSides {
				get {
					double[] temp = { A, B, A, B };
					return temp;
				}
			}
		}

		/// <summary>
		/// Trapezoid
		/// </summary>
		/// 
		class Trapezoid : Shape, IPolygon {
			public double A, B, H;
			public Trapezoid(double a, double b, double h) {
				A = a; B = b; H = h;
			}
			public override double _space => ((A + B) / 2) * H;
			public override double _perimeter => Math.Sqrt(H * H + (A - B) * (A - B));
			public double _hight => H;
			public double _base => A;
			public double _angle { get; set; }
			public uint _nSides => 4;
			public double[] _lSides {
				get {
					double[] temp = { A, B, A, B };
					return temp;
				}
			}
		}

		/// <summary>
		/// Cicle
		/// </summary>
		/// 
		class Cicle : Shape, IPolygon {
			public double R;
			public Cicle(double r) {
				R = r;
			}
			public override double _space => Math.PI * R * R;
			public override double _perimeter => 2 * Math.PI * R;

			public double _hight => R * 2;

			public double _base => R * 2;

			public double _angle { get; set; }

			public uint _nSides => 2;

			public double[] _lSides {
				get {
					double[] temp = { _base, _base, };
					return temp;
				}
			}
		}

		/// <summary>
		/// Elips
		/// </summary>
		/// 
		class Elips : Shape, IPolygon {
			public double A, B;
			public Elips(double a, double b) {
				A = a; B = b;
			}
			public override double _space => Math.PI * A * B;
			public override double _perimeter => 2 * Math.PI * Math.Sqrt((A * A + B * B) / 2.0);
			public double _hight => B * 2;

			public double _base => A * 2;

			public double _angle { get; set; }

			public uint _nSides => 2;

			public double[] _lSides {
				get {
					double[] temp = { _base, _hight, };
					return temp;
				}
			}
		}

		interface IPolygon {
			double _hight { get; }
			double _base { get; }
			double _angle { get; set; }
			uint _nSides { get; }
			double[] _lSides { get; }
			double _space { get; }
			double _perimeter { get; }
		}

		class Composition : IPolygon {
			private List<IPolygon> Shapes { get; set; }
			public double _hight => Shapes.Max(val => val._hight);
			public double _base => Shapes.Sum(val => val._base);
			public double _angle { get; set; }
			public uint _nSides => (uint)Shapes.Sum(val => val._nSides);
			public double[] _lSides {
				get {
					double[] temp = new double[_nSides];
					int capacity = 0;
					for(int i = 0; i < Shapes.Count(); ++i) {
						Array.Copy(Shapes[i]._lSides, 0, temp, capacity, Shapes[i]._lSides.Count());
						capacity += Shapes[i]._lSides.Count();
					}
					return temp;
				}
			}
			public double _space => Shapes.Sum(val => val._space);
			public double _perimeter => Shapes.Sum(val => val._perimeter);

			public void addShape(IPolygon sh) {
				if(Shapes == null) Shapes = new List<IPolygon> { sh };
				else Shapes.Add(sh);
			}

		}
	}
}
