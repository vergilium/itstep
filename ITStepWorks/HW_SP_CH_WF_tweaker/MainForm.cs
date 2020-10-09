using Microsoft.Win32;
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
	public partial class MainForm : Form {

		public MainForm() {
			InitializeComponent();
		}

		private void btn_Apply_Click(object sender, EventArgs e) {
			try {
				foreach (var item in gb_System.Controls.OfType<CheckBox>()) {
					if (item.Checked == true) {
						PropertyChange pc = null;
						RegChange.changeCollection.TryGetValue(item.Tag.ToString(), out pc);
						pc.DoWork();
					}
				}
				MessageBox.Show("All changed compleate!!!");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}

}
