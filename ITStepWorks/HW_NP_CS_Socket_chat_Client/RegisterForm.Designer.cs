namespace HW_NP_CS_Socket_chat_Client {
	partial class RegisterForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.tb_FName = new System.Windows.Forms.TextBox();
			this.tb_LName = new System.Windows.Forms.TextBox();
			this.tb_Pswd = new System.Windows.Forms.TextBox();
			this.tb_PswdConfirm = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.labelConfirmPassword = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Register = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HW_NP_CS_Socket_chat_Client.Properties.Resources.welcome;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(260, 93);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tb_Login
			// 
			this.tb_Login.Location = new System.Drawing.Point(12, 137);
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(260, 20);
			this.tb_Login.TabIndex = 1;
			this.tb_Login.Text = "Enter your Login";
			// 
			// tb_FName
			// 
			this.tb_FName.Location = new System.Drawing.Point(12, 163);
			this.tb_FName.Name = "tb_FName";
			this.tb_FName.Size = new System.Drawing.Size(260, 20);
			this.tb_FName.TabIndex = 2;
			this.tb_FName.Text = "Enter your first name";
			// 
			// tb_LName
			// 
			this.tb_LName.Location = new System.Drawing.Point(12, 189);
			this.tb_LName.Name = "tb_LName";
			this.tb_LName.Size = new System.Drawing.Size(260, 20);
			this.tb_LName.TabIndex = 3;
			this.tb_LName.Text = "Enter your last name";
			// 
			// tb_Pswd
			// 
			this.tb_Pswd.Location = new System.Drawing.Point(12, 237);
			this.tb_Pswd.Name = "tb_Pswd";
			this.tb_Pswd.PasswordChar = '*';
			this.tb_Pswd.Size = new System.Drawing.Size(260, 20);
			this.tb_Pswd.TabIndex = 4;
			this.tb_Pswd.UseSystemPasswordChar = true;
			this.tb_Pswd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tb_PswdConfirm
			// 
			this.tb_PswdConfirm.Location = new System.Drawing.Point(12, 281);
			this.tb_PswdConfirm.Name = "tb_PswdConfirm";
			this.tb_PswdConfirm.PasswordChar = '*';
			this.tb_PswdConfirm.Size = new System.Drawing.Size(260, 20);
			this.tb_PswdConfirm.TabIndex = 5;
			this.tb_PswdConfirm.UseSystemPasswordChar = true;
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(12, 221);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(80, 13);
			this.labelPassword.TabIndex = 6;
			this.labelPassword.Text = "Enter password";
			// 
			// labelConfirmPassword
			// 
			this.labelConfirmPassword.AutoSize = true;
			this.labelConfirmPassword.Location = new System.Drawing.Point(12, 265);
			this.labelConfirmPassword.Name = "labelConfirmPassword";
			this.labelConfirmPassword.Size = new System.Drawing.Size(90, 13);
			this.labelConfirmPassword.TabIndex = 7;
			this.labelConfirmPassword.Text = "Confirm password";
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
			this.btn_Cancel.FlatAppearance.BorderSize = 2;
			this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_Cancel.Location = new System.Drawing.Point(12, 354);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(90, 37);
			this.btn_Cancel.TabIndex = 8;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// btn_Register
			// 
			this.btn_Register.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
			this.btn_Register.FlatAppearance.BorderSize = 2;
			this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
			this.btn_Register.Location = new System.Drawing.Point(182, 354);
			this.btn_Register.Name = "btn_Register";
			this.btn_Register.Size = new System.Drawing.Size(90, 37);
			this.btn_Register.TabIndex = 9;
			this.btn_Register.Text = "Register";
			this.btn_Register.UseVisualStyleBackColor = true;
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.btn_Register;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_Cancel;
			this.ClientSize = new System.Drawing.Size(284, 411);
			this.Controls.Add(this.btn_Register);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.labelConfirmPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.tb_PswdConfirm);
			this.Controls.Add(this.tb_Pswd);
			this.Controls.Add(this.tb_LName);
			this.Controls.Add(this.tb_FName);
			this.Controls.Add(this.tb_Login);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RegisterForm";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Welcome to my chat";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.TextBox tb_FName;
		private System.Windows.Forms.TextBox tb_LName;
		private System.Windows.Forms.TextBox tb_Pswd;
		private System.Windows.Forms.TextBox tb_PswdConfirm;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.Label labelConfirmPassword;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Button btn_Register;
	}
}