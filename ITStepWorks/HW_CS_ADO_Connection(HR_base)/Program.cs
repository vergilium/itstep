using System;
using System.Windows.Forms;

namespace HW_CS_ADO_Connection_HR_base_ {
	static class Program {
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main() {
			DAL dal = new DAL();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(dal));
		}
	}
}
