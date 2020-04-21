using System;
using System.Collections.Generic;
using System.Text;

namespace HW_CS_8_Collections {
	class Line2D <T> where T: struct {
		public Point2D<T> Point1 { get; set; }
		public Point2D<T> Point2 { get; set; }

		public Line2D(Point2D<T> p1, Point2D<T> p2) {
			Point1 = p1; Point2 = p2;
		}
		public Line2D(T x1, T y1, T x2, T y2) {
			Point1 = new Point2D<T>(x1, y1);
			Point2 = new Point2D<T>(x2, y2);
		}
		public override string ToString() {
			return $"POINT_1 = [{Point1.X},{Point1.Y}];\nPOINT_2 = [{Point2.X},{Point2.Y}]";
		}
	}
}
