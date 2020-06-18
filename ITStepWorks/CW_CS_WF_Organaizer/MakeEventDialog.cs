using Organizer;
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
	public partial class MakeEventDialog : Form, IDisposable {
		ORGANIZER_ITEM item;
		bool isAcceptClose;
		public MakeEventDialog(ORGANIZER_ITEM? item) {
			InitializeComponent();
			isAcceptClose = false;
			dtPicker_EventStart.Format = DateTimePickerFormat.Custom;
			dtPicker_EventEnd.Format = DateTimePickerFormat.Custom;
			string[] ob = Enum.GetValues(typeof(Signal)).Cast<Signal>().Select(v => v.ToString()).ToArray();
			comboBox_TypeSignal.Items.AddRange(ob);
			comboBox_TypeSignal.SelectedIndex = 0;
			if (item != null) this.item = (ORGANIZER_ITEM)item;
			else item = new ORGANIZER_ITEM();
		}

		public ORGANIZER_ITEM ReturnData() {
			return item;
		}

		private void MakeEventDialog_FormClosing(object sender, FormClosingEventArgs e) {
			try {
				item.sDescription = textBox_Description.Text;
				item.dtStartTime = dtPicker_EventStart.Value;
				item.dtEndTime = dtPicker_EventEnd.Value;
				item.isActive = checkBox_EventEnable.Checked;
				Enum.TryParse(comboBox_TypeSignal.SelectedItem.ToString(), out item.eSignal);
			} catch {
				MessageBox.Show("Entered data incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void MakeEventDialog_Load(object sender, EventArgs e) {
			try {
				if (!item.Equals(default(ORGANIZER_ITEM))) {
					textBox_Description.Text = item.sDescription;
					dtPicker_EventStart.Value = item.dtStartTime;
					dtPicker_EventEnd.Value = item.dtEndTime;
					checkBox_EventEnable.Checked = item.isActive;
					comboBox_TypeSignal.SelectedItem = Enum.GetName(typeof(Signal), item.eSignal);
				}
			} catch {
				MessageBox.Show("Entered data incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void MakeEventDialog_FormClosed(object sender, FormClosedEventArgs e) {
			if (isAcceptClose) { this.DialogResult = DialogResult.OK; return; }
			if (MessageBox.Show("Save changed?", "Save?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				this.DialogResult = DialogResult.OK;
			} else {
				this.DialogResult = DialogResult.Cancel;
			}
		}

		private void btn_Accept_Click(object sender, EventArgs e) {
			isAcceptClose = true;
			this.Close();
		}
	}
}
