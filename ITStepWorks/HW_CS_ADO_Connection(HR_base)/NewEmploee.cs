using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW_CS_ADO_Connection_HR_base_ {
	public partial class NewEmploee : Form, IObserver {
		DAL dal;
		IObservable IOdata;
		int set_index = -1;
		public NewEmploee(IObservable obj) {
			InitializeComponent();

			IOdata = obj;
			IOdata.AddObserver(this);
		}

		public NewEmploee(IObservable obj, int set_index) {
			InitializeComponent();

			IOdata = obj;
			IOdata.AddObserver(this);
			this.set_index = set_index;
		}

		public void Update(object ob) {
			dal = (DAL)ob;
		}

		private bool CheckForm() {
			return true;
		}

		private void pb_photo_Click(object sender, EventArgs e) {
			if (ofd_OpenPhoto.ShowDialog() == DialogResult.OK) {
				pb_photo.Image = new Bitmap(ofd_OpenPhoto.FileName);
			}
		}

		private void btn_Save_Click(object sender, EventArgs e) {
			if (set_index >= 0) {
				dal.RemEmploee(dal.dbDataRecords[set_index].GetGuid(0));
			}
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
			if (set_index >= 0) {
				tb_firstname.Text = dal.dbDataRecords[set_index].GetString(1);
				tb_lname.Text = dal.dbDataRecords[set_index].GetString(2);
				tb_secondname.Text = dal.dbDataRecords[set_index].GetString(3);
				tb_position.Text = dal.dbDataRecords[set_index].GetString(4);
				tb_startorder.Text = dal.dbDataRecords[set_index].GetString(6);
				tb_endorder.Text = dal.dbDataRecords[set_index].GetString(7);
				tb_login.Text = dal.dbDataRecords[set_index].GetString(9);
				tb_passwd.Text = dal.dbDataRecords[set_index].GetString(10);
				dtp_dateborn.Value = dal.dbDataRecords[set_index].GetDateTime(5);
				pb_photo.Image = Photo.ToImage(dal.dbDataRecords[set_index].GetValue(8) as byte[]);
			}
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
			set_index = -1;
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
