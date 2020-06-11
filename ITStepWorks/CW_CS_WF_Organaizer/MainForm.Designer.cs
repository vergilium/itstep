namespace CW_CS_WF_Organaizer {
	partial class MainForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.analogClock = new UserControl_AnalogClock.AnalogClock();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// analogClock
			// 
			this.analogClock.BackColor = System.Drawing.Color.Transparent;
			this.analogClock.colorContur = System.Drawing.Color.DarkGreen;
			this.analogClock.colorDigits = System.Drawing.Color.Green;
			this.analogClock.colorHands = System.Drawing.Color.Green;
			this.analogClock.colorSityName = System.Drawing.Color.Red;
			this.analogClock.fontDigits = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.analogClock.Location = new System.Drawing.Point(0, 39);
			this.analogClock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.analogClock.Name = "analogClock";
			this.analogClock.Size = new System.Drawing.Size(314, 329);
			this.analogClock.sSityName = "Nikolaev";
			this.analogClock.TabIndex = 0;
			this.analogClock.uConturWidth = ((uint)(6u));
			this.analogClock.uDigitsIndent = 15;
			this.analogClock.uDigitsShift = 5;
			this.analogClock.uHandHourWidth = ((uint)(6u));
			this.analogClock.uHandMinWidth = ((uint)(4u));
			this.analogClock.uHandSecWidth = ((uint)(2u));
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.monthCalendar1.Location = new System.Drawing.Point(18, 372);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(313, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save as";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.ClientSize = new System.Drawing.Size(313, 552);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.analogClock);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "Organaizer";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControl_AnalogClock.AnalogClock analogClock;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

