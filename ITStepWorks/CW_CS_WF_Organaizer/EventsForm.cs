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
		IObservable organizer;
		public EventsForm(IObservable obj) {
			InitializeComponent();
			organizer = obj;
			organizer.AddObserver(this);
		}

		private void EventsForm_Load(object sender, EventArgs e) {
			organizer.NotifyObservers();
		}

		private void btn_NewEvent_Click(object sender, EventArgs e) {
		}

		public void Update(object ob) {
			Organizer.Organizer organizer = ob as Organizer.Organizer;
			EventsListBox.DataSource = organizer.orgList;
		}

		private void EventsForm_FormClosing(object sender, FormClosingEventArgs e) {
			organizer.RemoveObserver(this);
			organizer = null;
		}
	}
}
