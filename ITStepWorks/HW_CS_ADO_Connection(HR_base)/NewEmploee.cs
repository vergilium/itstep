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
		}

		private void NewEmploee_Load(object sender, EventArgs e) {
			IOdata.NotifyObservers();
		}
	}
}
