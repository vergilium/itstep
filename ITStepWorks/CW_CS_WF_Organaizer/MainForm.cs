using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_CS_WF_Organaizer {
	public partial class MainForm : Form {
		/// 
		/// переменные для перетаскивания формы
		bool isDrag = false;
		Point pDrag;


		public MainForm() {
			InitializeComponent();
		}


		///
		/// События для перетаскивания формы
		private void MainForm_MouseDown(object sender, MouseEventArgs e) {
			isDrag = true;
			pDrag = new Point(e.X, e.Y);
		}

		private void MainForm_MouseMove(object sender, MouseEventArgs e) {
			if (isDrag == true) this.Location = new Point((e.X - pDrag.X)+Location.X, (e.Y - pDrag.Y)+Location.Y);
		}

		private void MainForm_MouseUp(object sender, MouseEventArgs e) {
				isDrag = false;
		}

		////
		///События меню тулбара
		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
