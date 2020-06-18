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
	public enum SortMethod : int { SortDate, SortText };

	public partial class EventsForm : Form, IObserver {
		MakeEventDialog mdlg;

		IObservable IOrganizer;
		Organizer.Organizer organizer;

		private Comparison<ORGANIZER_ITEM>[] cmpSort = new Comparison<ORGANIZER_ITEM>[] {
			(a,b)=>a.dtStartTime.CompareTo(b.dtStartTime),
			(a,b)=>a.sDescription.CompareTo(b.sDescription)
		};

		int iCurPosition;
		public EventsForm(IObservable obj) {
			InitializeComponent();

			string[] items = Enum.GetValues(typeof(SortMethod)).Cast<SortMethod>().Select(v => v.ToString()).ToArray();
			comboBox_Sort.Items.AddRange(items);
			comboBox_Sort.SelectedIndex = 0;

			IOrganizer = obj;
			IOrganizer.AddObserver(this);
		}

		private bool Open_EditDialog(ORGANIZER_ITEM? item) {
			mdlg = new MakeEventDialog(item);
			if (mdlg.ShowDialog(this) == DialogResult.OK) 
				return true;
			else return false;

		}

		private void CalendarRefresh(object sender, EventArgs e) {
			monthCalendar.BoldedDates = organizer.GetEventDates();
		}

		private void EventsForm_Load(object sender, EventArgs e) {
			IOrganizer.NotifyObservers();
			CalendarRefresh(sender, e);
			organizer.orgList.ListChanged += CalendarRefresh;
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
			organizer.orgList.ListChanged -= CalendarRefresh;
			IOrganizer.RemoveObserver(this);
			IOrganizer = null;
		}

		private void EventsListBox_DoubleClick(object sender, EventArgs e) {
			if ((iCurPosition = EventsListBox.SelectedIndex) < 0) {
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

		private void comboBox_Sort_MouseCaptureChanged(object sender, EventArgs e) {
			
		}

		private void comboBox_Sort_SelectedIndexChanged(object sender, EventArgs e) {
			organizer?.orgList.Sort(cmpSort[comboBox_Sort.SelectedIndex]);
		}
	}
}
