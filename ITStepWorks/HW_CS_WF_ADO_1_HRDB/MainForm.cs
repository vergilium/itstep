using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_WF_ADO_1_HRDB {
	public partial class MainForm : Form {
		SqlConnection _conn;
		DbCommand sqlCmd;
		public MainForm(SqlConnection conn) {
			InitializeComponent();
			_conn = conn;
		}

		private void MainForm_Load(object sender, EventArgs e) {
			try {
				if(_conn.State != ConnectionState.Open) _conn.Open();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "Err connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Exit();
			}
			sqlCmd = new SqlCommand("exec selectEmployees null, null, 'alex'", _conn);
			dataGrid.DataSource = sqlCmd.ExecuteReader(); 
			
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
			_conn.Close();
		}
	}
}
