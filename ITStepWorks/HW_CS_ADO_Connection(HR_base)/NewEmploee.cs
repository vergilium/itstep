using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_ADO_Connection_HR_base_ {
	public partial class NewEmploee : Form, IObserver {
		DAL dal;
		IObservable IOdata;
		public NewEmploee(IObservable obj) {
			InitializeComponent();

			IOdata = obj;
			IOdata.AddObserver(this);
		}

		public void Update(object ob) {
			dal = (DAL)ob;
		}

		private bool CheckForm() {
			return true;
		}

		private void pb_photo_Click(object sender, EventArgs e) {
			if(ofd_OpenPhoto.ShowDialog() == DialogResult.OK) {
				pb_photo.Image = new Bitmap(ofd_OpenPhoto.FileName);
			}
		}

		private void btn_Save_Click(object sender, EventArgs e) {
			dal.NewEmploee(tb_firstname.Text, tb_lname.Text, 
				tb_secondname.Text,
				tb_position.Text,
				dtp_dateborn.Value,
				tb_startorder.Text,
				tb_endorder.Text,
				ofd_OpenPhoto.FileName,
				tb_login.Text,
				tb_passwd.Text);
			btn_Clear_Click(sender, e);
		}

		private void NewEmploee_Load(object sender, EventArgs e) {
			IOdata.NotifyObservers();
		}

		private void btn_Cancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void NewEmploee_FormClosing(object sender, FormClosingEventArgs e) {
			if (tb_firstname.Text != "" || tb_lname.Text != "" || tb_secondname.Text != "" || tb_position.Text != "" ||
				tb_startorder.Text != "" || tb_endorder.Text != "") {
				if (MessageBox.Show("Form have entered value.\n Do you need exit?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
					e.Cancel = true;
			}
		}

		private void btn_Clear_Click(object sender, EventArgs e) {
			tb_firstname.Text = "";
			tb_lname.Text = "";
			tb_secondname.Text = "";
			tb_position.Text = "";
			dtp_dateborn.Value = DateTime.Now;
			tb_startorder.Text = "";
			tb_endorder.Text = "";
			ofd_OpenPhoto.Dispose();
			pb_photo.Image = null;
			tb_login.Text = "";
			tb_passwd.Text = "";
		}
	}
}
