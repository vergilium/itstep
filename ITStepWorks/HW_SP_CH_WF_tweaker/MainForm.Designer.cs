namespace HW_SP_CH_WF_tweaker {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gb_System = new System.Windows.Forms.GroupBox();
			this.cb_Autorun = new System.Windows.Forms.CheckBox();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.menuStrip1.SuspendLayout();
			this.gb_System.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(370, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// backupToolStripMenuItem
			// 
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.backupToolStripMenuItem.Text = "&Backup";
			// 
			// restoreToolStripMenuItem
			// 
			this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
			this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.restoreToolStripMenuItem.Text = "&Restore";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// gb_System
			// 
			this.gb_System.Controls.Add(this.checkBox2);
			this.gb_System.Controls.Add(this.checkBox1);
			this.gb_System.Controls.Add(this.btn_Apply);
			this.gb_System.Controls.Add(this.cb_Autorun);
			this.gb_System.Location = new System.Drawing.Point(12, 27);
			this.gb_System.Name = "gb_System";
			this.gb_System.Size = new System.Drawing.Size(351, 89);
			this.gb_System.TabIndex = 1;
			this.gb_System.TabStop = false;
			this.gb_System.Text = "System";
			// 
			// cb_Autorun
			// 
			this.cb_Autorun.AutoSize = true;
			this.cb_Autorun.Location = new System.Drawing.Point(6, 19);
			this.cb_Autorun.Name = "cb_Autorun";
			this.cb_Autorun.Size = new System.Drawing.Size(105, 17);
			this.cb_Autorun.TabIndex = 0;
			this.cb_Autorun.Tag = "autorun_off";
			this.cb_Autorun.Text = "Disable autoruns";
			this.cb_Autorun.UseVisualStyleBackColor = true;
			// 
			// btn_Apply
			// 
			this.btn_Apply.Location = new System.Drawing.Point(219, 19);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(126, 28);
			this.btn_Apply.TabIndex = 3;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.UseVisualStyleBackColor = true;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(6, 42);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(86, 17);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Tag = "uac_off";
			this.checkBox1.Text = "Disable UAC";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(6, 65);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(141, 17);
			this.checkBox2.TabIndex = 5;
			this.checkBox2.Tag = "ramDiag_off";
			this.checkBox2.Text = "Disable RAM Diagnostic";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 124);
			this.Controls.Add(this.gb_System);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MyTweaker";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gb_System.ResumeLayout(false);
			this.gb_System.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.GroupBox gb_System;
		private System.Windows.Forms.CheckBox cb_Autorun;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
	}
}

