using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Organizer;

namespace CW_CS_WF_Organaizer {
	public partial class MainForm : Form, IObserver {
		/// 
		/// переменные для перетаскивания формы
		bool isDrag = false;
		Point pDrag;

		IObservable IOrganizer;
		Organizer.Organizer organizer;
		public MainForm(IObservable obj) {
			InitializeComponent();
			IOrganizer = obj;
			IOrganizer.AddObserver(this);
		}

		private void ShowEventsDialog() {
			EventsForm dlg = new EventsForm(IOrganizer);
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
			IOrganizer.NotifyObservers();
			CalendarRefresh(sender, e);
			organizer.orgList.ListChanged += CalendarRefresh;
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
		private void btn_upcomEvent_Click(object sender, EventArgs e) {
			try {
				MessageBox.Show(organizer.orgList.First(delegate (ORGANIZER_ITEM o) { return o.dtStartTime.Day >= DateTime.Now.Day; }).ToString());
			} catch {
				MessageBox.Show("No events for view!", "No events", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		public void Update(object ob) {
			organizer = (Organizer.Organizer)ob;
		}

		private void CalendarRefresh(object sender, EventArgs e) {
			monthCalendar_Main.BoldedDates = organizer.GetEventDates();
		}


	}
}
