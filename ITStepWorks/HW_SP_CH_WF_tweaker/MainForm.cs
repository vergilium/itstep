using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_SP_CH_WF_tweaker {
	public delegate bool ChangeDelegate();
	public partial class MainForm : Form {
		List<ChangeDelegate> changeCollection;
		public MainForm() {
			InitializeComponent();

			changeCollection = new List<ChangeDelegate>();
		}

		private void btn_Apply_Click(object sender, EventArgs e) {
			foreach(var item in changeCollection) {
				item.Invoke();
			}
		}

		private void cb_Autorun_CheckedChanged(object sender, EventArgs e) {
			if(cb_Autorun.Checked == true)
				changeCollection.Add(RegChange.Autorun_off);
			else 
				changeCollection.RemoveAt()
		}
	}
}
