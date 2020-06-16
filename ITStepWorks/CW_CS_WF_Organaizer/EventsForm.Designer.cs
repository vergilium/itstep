namespace CW_CS_WF_Organaizer {
	partial class EventsForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventsForm));
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.EventsListBox = new System.Windows.Forms.ListBox();
			this.btn_NewEvent = new System.Windows.Forms.Button();
			this.btn_EditEvent = new System.Windows.Forms.Button();
			this.btn_DelEvent = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
			this.monthCalendar1.Location = new System.Drawing.Point(0, -1);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			// 
			// EventsListBox
			// 
			this.EventsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.EventsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EventsListBox.ForeColor = System.Drawing.Color.Green;
			this.EventsListBox.FormattingEnabled = true;
			this.EventsListBox.Location = new System.Drawing.Point(0, 202);
			this.EventsListBox.MultiColumn = true;
			this.EventsListBox.Name = "EventsListBox";
			this.EventsListBox.Size = new System.Drawing.Size(332, 197);
			this.EventsListBox.TabIndex = 1;
			// 
			// btn_NewEvent
			// 
			this.btn_NewEvent.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btn_NewEvent.FlatAppearance.BorderSize = 2;
			this.btn_NewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_NewEvent.ForeColor = System.Drawing.Color.Green;
			this.btn_NewEvent.Location = new System.Drawing.Point(12, 167);
			this.btn_NewEvent.Name = "btn_NewEvent";
			this.btn_NewEvent.Size = new System.Drawing.Size(75, 29);
			this.btn_NewEvent.TabIndex = 2;
			this.btn_NewEvent.Text = "New Event";
			this.btn_NewEvent.UseVisualStyleBackColor = true;
			this.btn_NewEvent.Click += new System.EventHandler(this.btn_NewEvent_Click);
			// 
			// btn_EditEvent
			// 
			this.btn_EditEvent.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btn_EditEvent.FlatAppearance.BorderSize = 2;
			this.btn_EditEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_EditEvent.ForeColor = System.Drawing.Color.Green;
			this.btn_EditEvent.Location = new System.Drawing.Point(93, 167);
			this.btn_EditEvent.Name = "btn_EditEvent";
			this.btn_EditEvent.Size = new System.Drawing.Size(75, 29);
			this.btn_EditEvent.TabIndex = 3;
			this.btn_EditEvent.Text = "Edit Event";
			this.btn_EditEvent.UseVisualStyleBackColor = true;
			// 
			// btn_DelEvent
			// 
			this.btn_DelEvent.FlatAppearance.BorderColor = System.Drawing.Color.Green;
			this.btn_DelEvent.FlatAppearance.BorderSize = 2;
			this.btn_DelEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_DelEvent.ForeColor = System.Drawing.Color.Green;
			this.btn_DelEvent.Location = new System.Drawing.Point(174, 167);
			this.btn_DelEvent.Name = "btn_DelEvent";
			this.btn_DelEvent.Size = new System.Drawing.Size(75, 29);
			this.btn_DelEvent.TabIndex = 4;
			this.btn_DelEvent.Text = "Del Event";
			this.btn_DelEvent.UseVisualStyleBackColor = true;
			// 
			// EventsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.ClientSize = new System.Drawing.Size(332, 411);
			this.Controls.Add(this.btn_DelEvent);
			this.Controls.Add(this.btn_EditEvent);
			this.Controls.Add(this.btn_NewEvent);
			this.Controls.Add(this.EventsListBox);
			this.Controls.Add(this.monthCalendar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EventsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EventsForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventsForm_FormClosing);
			this.Load += new System.EventHandler(this.EventsForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.ListBox EventsListBox;
		private System.Windows.Forms.Button btn_NewEvent;
		private System.Windows.Forms.Button btn_EditEvent;
		private System.Windows.Forms.Button btn_DelEvent;
	}
}