using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Organizer;

namespace CW_CS_WF_Organaizer {
	public partial class EventsForm : Form, IObserver {
		MakeEventDialog mdlg;

		IObservable IOrganizer;
		Organizer.Organizer organizer;

		int iCurPosition;
		public EventsForm(IObservable obj) {
			InitializeComponent();
			IOrganizer = obj as Organizer.Organizer;
			IOrganizer.AddObserver(this);
		}

		private bool Open_EditDialog(ORGANIZER_ITEM? item) {
			mdlg = new MakeEventDialog(item);
			if (mdlg.ShowDialog(this) == DialogResult.OK) 
				return true;
			else return false;

		}

		private void CalendarRefresh() {
			monthCalendar.BoldedDates = organizer.orgList.Select(d => d.dtStartTime).ToArray();
		}

		private void EventsForm_Load(object sender, EventArgs e) {
			IOrganizer.NotifyObservers();
			CalendarRefresh();
		}

		private void btn_NewEvent_Click(object sender, EventArgs e) {
			if (Open_EditDialog(null)) {
				organizer.Add(mdlg.ReturnData());
				mdlg.Dispose();

			}
		}

		public void Update(object ob) {
			organizer = ob as Organizer.Organizer;
			EventsListBox.DataSource = organizer.orgList;
		}

		private void EventsForm_FormClosing(object sender, FormClosingEventArgs e) {
			IOrganizer.RemoveObserver(this);
			IOrganizer = null;
		}

		private void EventsListBox_DoubleClick(object sender, EventArgs e) {
			if ((iCurPosition = EventsListBox.SelectedIndex) <= 0) {
				btn_NewEvent_Click(sender, e);
			} else {
				if (Open_EditDialog(organizer.orgList[iCurPosition])) {
					organizer.RemoveAt(iCurPosition);
					organizer.Add(mdlg.ReturnData());
					mdlg.Dispose();
				}
			}
		}

		private void btn_DelEvent_Click(object sender, EventArgs e) {
			if ((iCurPosition = EventsListBox.SelectedIndex) < 0) {
				MessageBox.Show("No items", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
			} else {
				organizer.RemoveAt(iCurPosition);
			}
		}
	}
}
