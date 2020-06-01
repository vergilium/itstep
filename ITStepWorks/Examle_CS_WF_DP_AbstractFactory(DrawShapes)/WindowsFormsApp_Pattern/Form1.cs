using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Pattern {
	public partial class Form1 : Form {
		Shapes selShape = Shapes.Rectangle;
		AbstractShapeFactory[] factories = new AbstractShapeFactory[] {
			new RedFactory(),
			new GreenFactory(),
			new BlueFactory()
		};
		List<Shape> shapes = new List<Shape>();
		AbstractShapeFactory factory = null;
		Point p;


		public Form1() {
			factory = factories[0];
			InitializeComponent();
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e) {
			p = new Point(e.X, e.Y);
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e) {
			shapes.Add(factory.GetShape(selShape, new Rectangle {
				X = p.X,
				Y = p.Y,
				Width = e.X - p.X,
				Height = e.Y - p.Y
			}));
			Invalidate();
		}

		private void Form1_Paint(object sender, PaintEventArgs e) {
			foreach (var shape in shapes) {
				shape.Draw(e.Graphics);
			}
		}
	}
}
