using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_ADO_Connection_HR_base_ {
	public partial class MainForm : Form, IObserver {
		DAL dal;
		IObservable IOdata;

		public MainForm(IObservable obj) {
			InitializeComponent();
			IOdata = obj;
			IOdata.AddObserver(this);
		}

		private void MainForm_Load(object sender, EventArgs e) {
			IOdata.NotifyObservers();
			if (dal.ConnectionOpen()) {
				dal.GetEmploees();
				dgv_emploeers.DataSource = dal.dbDataRecords;

			}
			this.Text = $"HR manager connection {dal.GetConnectionState()}";
		}


		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			dal.ConnectionClose();
		}

		private void dgv_emploeers_CellEnter(object sender, DataGridViewCellEventArgs e) {
			tb_id.Text = dgv_emploeers.Rows[e.RowIndex].Cells["id"].Value.ToString().ToUpper();
			tb_dateborn.Text = dgv_emploeers.Rows[e.RowIndex].Cells["birstday"].Value.ToString();
			tb_position.Text = dgv_emploeers.Rows[e.RowIndex].Cells["position"].Value.ToString();
			tb_startorder.Text = dgv_emploeers.Rows[e.RowIndex].Cells["startorder"].Value.ToString();
			tb_endorder.Text = dgv_emploeers.Rows[e.RowIndex].Cells["endorder"].Value.ToString();
			pb_Photo.Image = Photo.Resize(Photo.ToImage(dgv_emploeers.Rows[e.RowIndex].Cells["photo"]?.Value as byte[]),105,124);
		}

		private void dgv_emploeers_DataSourceChanged(object sender, EventArgs e) {
			try {
				dgv_emploeers.Columns[0].Visible = false;
				dgv_emploeers.Columns[4].Visible = false;
				dgv_emploeers.Columns[5].Visible = false;
				dgv_emploeers.Columns[6].Visible = false;
				dgv_emploeers.Columns[7].Visible = false;
				dgv_emploeers.Columns[8].Visible = false;
				dgv_emploeers.Columns[9].Visible = false;
				dgv_emploeers.Columns[10].Visible = false;
				dgv_emploeers.TopLeftHeaderCell.Value = "№";
			} catch (ArgumentOutOfRangeException) {

			}
		}

		private void newEmploeeToolStripMenuItem_Click(object sender, EventArgs e) {
			tsb_add_Click(sender, e);
		}

		private void tsb_add_Click(object sender, EventArgs e) {
			Form nemp = new NewEmploee(IOdata);
			nemp.ShowDialog();
		}
		private void tsb_edit_Click(object sender, EventArgs e) {
			Form nemp = new NewEmploee(IOdata, dgv_emploeers.CurrentRow.Index);
			nemp.ShowDialog();
		}

		private void tsb_remove_Click(object sender, EventArgs e) {
			if(tb_id.Text != "") {
				if (MessageBox.Show($"Delete employee {tb_id.Text}", "Info",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Information) == DialogResult.Yes) {
					dal.RemEmploee(Guid.Parse(tb_id.Text));
				} else {
					return;
				}
			}	
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e) {
			if (dal.GetConnectionState() != ConnectionState.Open) {
				if (dal.ConnectionOpen()) {
					dgv_emploeers.DataSource = dal.dbDataRecords;
				}
			}
			this.Text = $"HR manager connection {dal.GetConnectionState()}";
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e) {
			if (dal.ConnectionClose()) {
				dgv_emploeers.DataSource = null;
			}
			this.Text = $"HR manager connection {dal.GetConnectionState()}";
		}

		public void Update(object ob) {
			dal = (DAL)ob;
		}

	}
}
