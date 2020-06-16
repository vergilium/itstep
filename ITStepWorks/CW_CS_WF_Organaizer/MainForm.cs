using System;
using System.Drawing;
using System.Windows.Forms;
using Organizer;

namespace CW_CS_WF_Organaizer {
	public partial class MainForm : Form, IObserver {
		/// 
		/// переменные для перетаскивания формы
		bool isDrag = false;
		Point pDrag;

		IObservable organizer;

		public MainForm(IObservable obj) {
			InitializeComponent();
			organizer = obj;
			organizer.AddObserver(this);
		}

		private void ShowEventsDialog() {
			EventsForm dlg = new EventsForm(organizer);
			if (dlg.ShowDialog(this) == DialogResult.OK) {

			}
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

		private void btn_Close_Click(object sender, EventArgs e) {
			this.Close();
		}


		////
		///Инициализация основных переменных
		private void MainForm_Load(object sender, EventArgs e) {

		}

		////
		///Кнопки на отрытие диалога событий
		private void analogClock_DoubleClick(object sender, EventArgs e) {
			ShowEventsDialog();
		}
		private void btn_ViewEvents_Click(object sender, EventArgs e) {
			ShowEventsDialog();
		}
		private void eventsToolStripMenuItem_Click(object sender, EventArgs e) {
			ShowEventsDialog();
		}


		public void Update(object ob) {
			Organizer.Organizer organizer = (Organizer.Organizer)ob;
		}
	}
}
