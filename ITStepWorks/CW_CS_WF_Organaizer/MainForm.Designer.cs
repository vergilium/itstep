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
			this.monthCalendar_Main = new System.Windows.Forms.MonthCalendar();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.upcomingEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.btn_ViewEvents = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_upcomEvent = new System.Windows.Forms.Button();
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
			this.analogClock.fontDigits = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.analogClock.DoubleClick += new System.EventHandler(this.analogClock_DoubleClick);
			this.analogClock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.analogClock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.analogClock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			// 
			// monthCalendar_Main
			// 
			this.monthCalendar_Main.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.monthCalendar_Main.Location = new System.Drawing.Point(18, 372);
			this.monthCalendar_Main.Name = "monthCalendar_Main";
			this.monthCalendar_Main.TabIndex = 1;
			this.monthCalendar_Main.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.monthCalendar_Main.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(313, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip";
			this.menuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.menuStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.menuStrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
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
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save as";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
			this.infoToolStripMenuItem.Text = "&Info";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.CheckOnClick = true;
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.upcomingEventToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// eventsToolStripMenuItem
			// 
			this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
			this.eventsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.eventsToolStripMenuItem.Text = "&Events";
			this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
			// 
			// upcomingEventToolStripMenuItem
			// 
			this.upcomingEventToolStripMenuItem.Name = "upcomingEventToolStripMenuItem";
			this.upcomingEventToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.upcomingEventToolStripMenuItem.Text = "&Upcoming event";
			// 
			// btn_ViewEvents
			// 
			this.btn_ViewEvents.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btn_ViewEvents.FlatAppearance.BorderSize = 2;
			this.btn_ViewEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_ViewEvents.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_ViewEvents.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.btn_ViewEvents.Location = new System.Drawing.Point(194, 372);
			this.btn_ViewEvents.Name = "btn_ViewEvents";
			this.btn_ViewEvents.Size = new System.Drawing.Size(107, 59);
			this.btn_ViewEvents.TabIndex = 3;
			this.btn_ViewEvents.Text = "View events";
			this.btn_ViewEvents.UseVisualStyleBackColor = true;
			this.btn_ViewEvents.Click += new System.EventHandler(this.btn_ViewEvents_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btn_Close.Location = new System.Drawing.Point(283, 0);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(30, 24);
			this.btn_Close.TabIndex = 4;
			this.btn_Close.Text = "X";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_upcomEvent
			// 
			this.btn_upcomEvent.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btn_upcomEvent.FlatAppearance.BorderSize = 2;
			this.btn_upcomEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_upcomEvent.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_upcomEvent.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.btn_upcomEvent.Location = new System.Drawing.Point(194, 475);
			this.btn_upcomEvent.Name = "btn_upcomEvent";
			this.btn_upcomEvent.Size = new System.Drawing.Size(107, 59);
			this.btn_upcomEvent.TabIndex = 5;
			this.btn_upcomEvent.Text = "Upcoming event";
			this.btn_upcomEvent.UseVisualStyleBackColor = true;
			this.btn_upcomEvent.Click += new System.EventHandler(this.btn_upcomEvent_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.ClientSize = new System.Drawing.Size(313, 552);
			this.Controls.Add(this.btn_upcomEvent);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_ViewEvents);
			this.Controls.Add(this.monthCalendar_Main);
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
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private UserControl_AnalogClock.AnalogClock analogClock;
		private System.Windows.Forms.MonthCalendar monthCalendar_Main;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.Button btn_ViewEvents;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
		private System.Windows.Forms.Button btn_upcomEvent;
		private System.Windows.Forms.ToolStripMenuItem upcomingEventToolStripMenuItem;
	}
}

