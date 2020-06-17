namespace CW_CS_WF_Organaizer {
	partial class MakeEventDialog {
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
			this.label_EDescription = new System.Windows.Forms.Label();
			this.textBox_Description = new System.Windows.Forms.TextBox();
			this.dtPicker_EventStart = new System.Windows.Forms.DateTimePicker();
			this.label_EventStart = new System.Windows.Forms.Label();
			this.dtPicker_EventEnd = new System.Windows.Forms.DateTimePicker();
			this.label_EventEnd = new System.Windows.Forms.Label();
			this.checkBox_EventEnable = new System.Windows.Forms.CheckBox();
			this.comboBox_TypeSignal = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label_EDescription
			// 
			this.label_EDescription.AutoSize = true;
			this.label_EDescription.ForeColor = System.Drawing.Color.Green;
			this.label_EDescription.Location = new System.Drawing.Point(12, 147);
			this.label_EDescription.Name = "label_EDescription";
			this.label_EDescription.Size = new System.Drawing.Size(89, 13);
			this.label_EDescription.TabIndex = 0;
			this.label_EDescription.Text = "Event description";
			// 
			// textBox_Description
			// 
			this.textBox_Description.Location = new System.Drawing.Point(12, 163);
			this.textBox_Description.Multiline = true;
			this.textBox_Description.Name = "textBox_Description";
			this.textBox_Description.Size = new System.Drawing.Size(200, 78);
			this.textBox_Description.TabIndex = 1;
			this.textBox_Description.Text = "Enter description";
			// 
			// dtPicker_EventStart
			// 
			this.dtPicker_EventStart.CustomFormat = "ddd dd.MMMM.yyy HH:mm";
			this.dtPicker_EventStart.Location = new System.Drawing.Point(12, 34);
			this.dtPicker_EventStart.Name = "dtPicker_EventStart";
			this.dtPicker_EventStart.Size = new System.Drawing.Size(200, 20);
			this.dtPicker_EventStart.TabIndex = 2;
			// 
			// label_EventStart
			// 
			this.label_EventStart.AutoSize = true;
			this.label_EventStart.ForeColor = System.Drawing.Color.Green;
			this.label_EventStart.Location = new System.Drawing.Point(12, 18);
			this.label_EventStart.Name = "label_EventStart";
			this.label_EventStart.Size = new System.Drawing.Size(60, 13);
			this.label_EventStart.TabIndex = 3;
			this.label_EventStart.Text = "Event Start";
			// 
			// dtPicker_EventEnd
			// 
			this.dtPicker_EventEnd.CustomFormat = "ddd dd.MMMM.yyy HH:mm";
			this.dtPicker_EventEnd.Location = new System.Drawing.Point(12, 77);
			this.dtPicker_EventEnd.Name = "dtPicker_EventEnd";
			this.dtPicker_EventEnd.Size = new System.Drawing.Size(200, 20);
			this.dtPicker_EventEnd.TabIndex = 4;
			// 
			// label_EventEnd
			// 
			this.label_EventEnd.AutoSize = true;
			this.label_EventEnd.ForeColor = System.Drawing.Color.Green;
			this.label_EventEnd.Location = new System.Drawing.Point(9, 61);
			this.label_EventEnd.Name = "label_EventEnd";
			this.label_EventEnd.Size = new System.Drawing.Size(57, 13);
			this.label_EventEnd.TabIndex = 5;
			this.label_EventEnd.Text = "Event End";
			// 
			// checkBox_EventEnable
			// 
			this.checkBox_EventEnable.AutoSize = true;
			this.checkBox_EventEnable.ForeColor = System.Drawing.Color.Green;
			this.checkBox_EventEnable.Location = new System.Drawing.Point(12, 114);
			this.checkBox_EventEnable.Name = "checkBox_EventEnable";
			this.checkBox_EventEnable.Size = new System.Drawing.Size(89, 17);
			this.checkBox_EventEnable.TabIndex = 6;
			this.checkBox_EventEnable.Text = "Event enable";
			this.checkBox_EventEnable.UseVisualStyleBackColor = true;
			// 
			// comboBox_TypeSignal
			// 
			this.comboBox_TypeSignal.FormattingEnabled = true;
			this.comboBox_TypeSignal.Location = new System.Drawing.Point(107, 114);
			this.comboBox_TypeSignal.Name = "comboBox_TypeSignal";
			this.comboBox_TypeSignal.Size = new System.Drawing.Size(105, 21);
			this.comboBox_TypeSignal.TabIndex = 7;
			// 
			// MakeEventDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(10)))), ((int)(((byte)(5)))));
			this.ClientSize = new System.Drawing.Size(219, 246);
			this.Controls.Add(this.comboBox_TypeSignal);
			this.Controls.Add(this.checkBox_EventEnable);
			this.Controls.Add(this.label_EventEnd);
			this.Controls.Add(this.dtPicker_EventEnd);
			this.Controls.Add(this.label_EventStart);
			this.Controls.Add(this.dtPicker_EventStart);
			this.Controls.Add(this.textBox_Description);
			this.Controls.Add(this.label_EDescription);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MakeEventDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MakeEventDialog";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeEventDialog_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MakeEventDialog_FormClosed);
			this.Load += new System.EventHandler(this.MakeEventDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_EDescription;
		private System.Windows.Forms.TextBox textBox_Description;
		private System.Windows.Forms.DateTimePicker dtPicker_EventStart;
		private System.Windows.Forms.Label label_EventStart;
		private System.Windows.Forms.DateTimePicker dtPicker_EventEnd;
		private System.Windows.Forms.Label label_EventEnd;
		private System.Windows.Forms.CheckBox checkBox_EventEnable;
		private System.Windows.Forms.ComboBox comboBox_TypeSignal;
	}
}