using System;
using System.Collections.Generic;
using System.Text;

namespace HW_CS_8_Collections {

	public class Point2D<T> {
		public T X { get; set; }
		public T Y { get; set; }

		public Point2D(T x, T y) {
			X = x; Y = y;
		}
		public Point2D() {
			X = default(T);
			Y = default(T);
		}
	}

	class Point3D : Point2D<int> {
		public int Z { get; set; }

		public Point3D(int x, int y, int z) : base(x,y) {
			Z = z;
		}
		public Point3D() {
			Z = 0;
		}

		public override string ToString() {
			return $"[X] = {base.X}; [Y] = {base.Y}; [Z] = {Z}";
		}
	}
}
