using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Pattern {
	public interface IDrawable {
		Color color { get; set; }
		void Draw(Graphics gr);
	}
	public interface IShape {
		float Angle { get; set; }
		Point leftTopPoint { get; set; }
		Size rectSize { get; set; }
	}
	public abstract class Shape : IDrawable, IShape {
		public float Angle { get ; set ; }
		public Point leftTopPoint { get ; set; }
		public Size rectSize { get ; set; }
		public Color color { get ; set ; }
		public abstract void Draw(Graphics gr);

	}

	public class _Rectangle : Shape {
		public override void Draw(Graphics gr) {
			gr.DrawRectangle(
				new Pen(color, 2),
				leftTopPoint.X,
				leftTopPoint.Y,
				rectSize.Width,
				rectSize.Height
				);
		}
	}
	public class _Triangle : Shape {
		public override void Draw(Graphics gr) {
			Pen pen = new Pen(color, 2);
			gr.DrawLine(pen,
				leftTopPoint,
				new Point(
					leftTopPoint.X + rectSize.Width,
					leftTopPoint.Y
					)
				);
			gr.DrawLine(pen,
				new Point(
					leftTopPoint.X + rectSize.Width,
					leftTopPoint.Y
					),
				new Point(
					leftTopPoint.X + rectSize.Width/2,
					leftTopPoint.Y + rectSize.Height
					)
				);
			gr.DrawLine(pen,
				new Point(
					leftTopPoint.X + rectSize.Width/2,
					leftTopPoint.Y + rectSize.Height
					),
				leftTopPoint
				);	
		}
	}

	public class _Ellipse : Shape {
		public override void Draw(Graphics gr) {
			gr.DrawEllipse(
				new Pen(color, 2),
				leftTopPoint.X,
				leftTopPoint.Y,
				rectSize.Width,
				rectSize.Height
				);
		}
	}

	public enum Shapes { Rectangle, Triangle, Ellipse }
	public abstract class AbstractShapeFactory {
		public Shape GetShape(Shapes shape, Rectangle rect) {
			switch (shape) {
				case Shapes.Rectangle: return GetRectangle(rect);
				case Shapes.Triangle:return GetTriangle(rect);
				case Shapes.Ellipse: return GetEllipse(rect);
				default:
					return null;
			}
			
		}
		public abstract Shape GetRectangle(Rectangle rect);
		public abstract Shape GetTriangle(Rectangle rect);
		public abstract Shape GetEllipse(Rectangle rect);
	}

	public class BaseFactory : AbstractShapeFactory {
		private Color color;

		public BaseFactory(Color color) {
			this.color = color;
		}
		public override Shape GetEllipse(Rectangle rect) {
			return new _Ellipse {
				Angle = 0,
				color = color,
				leftTopPoint = rect.Location,
				rectSize = rect.Size
			};
		}

		public override Shape GetRectangle(Rectangle rect) {
			return new _Rectangle {
				Angle = 0,
				color = color,
				leftTopPoint = rect.Location,
				rectSize = rect.Size
			};
		}

		public override Shape GetTriangle(Rectangle rect) {
			return new _Triangle {
				Angle = 0,
				color = color,
				leftTopPoint = rect.Location,
				rectSize = rect.Size
			};
		}
	}

	public class RedFactory : BaseFactory {
		public RedFactory() : base(Color.Red) { }
	}

	public class GreenFactory : BaseFactory {
		public GreenFactory() : base(Color.Green) { }
	}
	public class BlueFactory : BaseFactory {
		public BlueFactory() : base(Color.Blue) { }
	}
}
