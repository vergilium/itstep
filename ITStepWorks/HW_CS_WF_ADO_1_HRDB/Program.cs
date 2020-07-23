using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_WF_ADO_1_HRDB {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			string connString = ConfigurationManager.ConnectionStrings["HRresurceConnectionString"].ConnectionString;
			SqlConnection conn = new SqlConnection(connString);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(conn));

		}
	}
}
