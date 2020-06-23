using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data_Access_Layer;
using Organizer;

namespace CW_CS_WF_Organaizer {
	public partial class MainForm : Form, IObserver {
		/// 
		/// переменные для перетаскивания формы
		bool isDrag = false;
		Point pDrag;
		////
		/// Переменные для обсервера и основного класса данных
		IObservable IOrganizer;
		Organizer.Organizer organizer;

		Data_Access_Layer.DAL dataLayer = new Data_Access_Layer.DAL();
		/// <summary>
		/// Constructor MainForm
		/// </summary>
		/// <param name="obj">IObservable value</param>
		public MainForm(IObservable obj) {
			InitializeComponent();

			saveFileDialog.Filter = Data_Access_Layer.DAL.GetFilterTypes();
			saveFileDialog.FilterIndex = Data_Access_Layer.DAL.GetFilterTypesCount();
			openFileDialog.Filter = Data_Access_Layer.DAL.GetFilterTypes();
			openFileDialog.FilterIndex = Data_Access_Layer.DAL.GetFilterTypesCount();

			IOrganizer = obj;
			IOrganizer.AddObserver(this);
		}
		/// <summary>
		/// Method for create and show EventsForm dialog
		/// </summary>
		private void ShowEventsDialog() {
			EventsForm dlg = new EventsForm(IOrganizer);
			if (dlg.ShowDialog(this) == DialogResult.OK) {

			}
		}

		public void Update(object ob) {
			organizer = (Organizer.Organizer)ob;
		}

		private void CalendarRefresh(object sender, EventArgs e) {
			monthCalendar_Main.BoldedDates = organizer.GetEventDates();
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
		private void openToolStripMenuItem_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			else {
				if (dataLayer.LoadFile(openFileDialog.FileName, out object obj)) {
					organizer.SetListData(obj as Organizer.Organizer);
					MainForm_Load(sender, e);
				}
			}
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}
		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
			else {
				object obj = (Organizer.Organizer)organizer;
				dataLayer.SaveFile(saveFileDialog.FileName, ref obj);
			}
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
			string msg = organizer.GetFirstDate()?.ToString();
				MessageBox.Show((msg!=null?msg:"No events for view!"), "Info", MessageBoxButtons.OK);
		}

		private void timer_EventActive_Tick(object sender, EventArgs e) {
			organizer.SignalActive();
		}
	}
}
