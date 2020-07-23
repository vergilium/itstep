namespace HW_CS_WF_ADO_1_HRDB {
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
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.AllowUserToOrderColumns = true;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fName,
            this.lName,
            this.sName});
			this.dataGrid.Location = new System.Drawing.Point(12, 154);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(723, 284);
			this.dataGrid.TabIndex = 0;
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			// 
			// fName
			// 
			this.fName.DataPropertyName = "fName";
			this.fName.HeaderText = "First Name";
			this.fName.Name = "fName";
			// 
			// lName
			// 
			this.lName.HeaderText = "Last Name";
			this.lName.Name = "lName";
			// 
			// sName
			// 
			this.sName.HeaderText = "Second Name";
			this.sName.Name = "sName";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 450);
			this.Controls.Add(this.dataGrid);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn fName;
		private System.Windows.Forms.DataGridViewTextBoxColumn lName;
		private System.Windows.Forms.DataGridViewTextBoxColumn sName;
	}
}

