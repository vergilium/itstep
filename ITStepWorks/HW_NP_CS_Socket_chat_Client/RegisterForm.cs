using HW_NP_CS_Socket_chat_Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_NP_CS_Socket_chat_Client {
	public partial class RegisterForm : Form {
		public RegisterForm() {
			InitializeComponent();
			btn_Register.Enabled = false;
			//mtb_ServerAddr.Tag = IPAddress.Any;
		}

		private void tb_changed(object sender, EventArgs e) {
			foreach(TextBox item in this.Controls.OfType<TextBox>()) {
				if(String.IsNullOrEmpty(item.Text.Trim(' ')) || item.Text.Equals(item.Tag)) {
					label_err.Text = "Pleas fill all filds!";
					return;
				}
			}
			if (!tb_Pswd.Text.Equals(tb_PswdConfirm.Text)) {
				label_err.Text = "Passwords not equal!!!";
				return;
			}
			IPAddress ip;
			if (!IPAddress.TryParse(mtb_ServerAddr.Text, out ip)) { 
				label_err.Text = "Incorrect Server address";
				return;
			}
			mtb_ServerAddr.Tag = ip;
			label_err.Text = String.Empty;
			btn_Register.Enabled = true;
		}

		private void btn_Cancel_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void btn_Register_Click(object sender, EventArgs e) {
			try {
				SocketClient client = new SocketClient(mtb_ServerAddr.Tag as IPAddress);
				Registration register = new Registration {
					login = tb_Login.Text,
					firstName = tb_FName.Text,
					lastName = tb_LName.Text,
					password = tb_Pswd.Text,
					server = mtb_ServerAddr.Tag.ToString()
				};
				byte[] json = register.Register();
				Console.WriteLine(json);
				client.Send(json);
				if (json.Length > 0) {
					MessageBox.Show("Success!!!"); 
				} else MessageBox.Show("ERROR!!!");
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void tb_MouseClick(object sender, MouseEventArgs e) {
			TextBox tb = sender as TextBox;
			if (tb.Text.Equals(tb.Tag)) tb.Text = String.Empty;
		}

		private void tb_FocusFalse(object sender, EventArgs e) {
			TextBox tb = sender as TextBox;
			if(tb.Text.Trim(' ').Length == 0) {
				tb.Text = tb.Tag as string;
			}
		}
	}
}
