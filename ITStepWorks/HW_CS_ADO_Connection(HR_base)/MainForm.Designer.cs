namespace HW_CS_ADO_Connection_HR_base_ {
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
			this.dgv_emploeers = new System.Windows.Forms.DataGridView();
			this.gb_Account = new System.Windows.Forms.GroupBox();
			this.tb_endorder = new System.Windows.Forms.TextBox();
			this.lb_endorder = new System.Windows.Forms.Label();
			this.tb_startorder = new System.Windows.Forms.TextBox();
			this.lb_startorder = new System.Windows.Forms.Label();
			this.tb_position = new System.Windows.Forms.TextBox();
			this.lb_position = new System.Windows.Forms.Label();
			this.tb_dateborn = new System.Windows.Forms.TextBox();
			this.lb_born = new System.Windows.Forms.Label();
			this.pb_Photo = new System.Windows.Forms.PictureBox();
			this.lb_ID = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newEmploeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgv_emploeers)).BeginInit();
			this.gb_Account.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_emploeers
			// 
			this.dgv_emploeers.AllowUserToAddRows = false;
			this.dgv_emploeers.AllowUserToDeleteRows = false;
			this.dgv_emploeers.AllowUserToOrderColumns = true;
			this.dgv_emploeers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_emploeers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgv_emploeers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_emploeers.Location = new System.Drawing.Point(12, 50);
			this.dgv_emploeers.Name = "dgv_emploeers";
			this.dgv_emploeers.ReadOnly = true;
			this.dgv_emploeers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_emploeers.Size = new System.Drawing.Size(347, 159);
			this.dgv_emploeers.TabIndex = 0;
			this.dgv_emploeers.DataSourceChanged += new System.EventHandler(this.dgv_emploeers_DataSourceChanged);
			this.dgv_emploeers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emploeers_CellEnter);
			// 
			// gb_Account
			// 
			this.gb_Account.Controls.Add(this.tb_endorder);
			this.gb_Account.Controls.Add(this.lb_endorder);
			this.gb_Account.Controls.Add(this.tb_startorder);
			this.gb_Account.Controls.Add(this.lb_startorder);
			this.gb_Account.Controls.Add(this.tb_position);
			this.gb_Account.Controls.Add(this.lb_position);
			this.gb_Account.Controls.Add(this.tb_dateborn);
			this.gb_Account.Controls.Add(this.lb_born);
			this.gb_Account.Controls.Add(this.pb_Photo);
			this.gb_Account.Controls.Add(this.lb_ID);
			this.gb_Account.Controls.Add(this.tb_id);
			this.gb_Account.Location = new System.Drawing.Point(365, 50);
			this.gb_Account.Name = "gb_Account";
			this.gb_Account.Size = new System.Drawing.Size(436, 159);
			this.gb_Account.TabIndex = 1;
			this.gb_Account.TabStop = false;
			this.gb_Account.Text = "Account";
			// 
			// tb_endorder
			// 
			this.tb_endorder.Location = new System.Drawing.Point(74, 123);
			this.tb_endorder.Name = "tb_endorder";
			this.tb_endorder.ReadOnly = true;
			this.tb_endorder.Size = new System.Drawing.Size(245, 20);
			this.tb_endorder.TabIndex = 12;
			// 
			// lb_endorder
			// 
			this.lb_endorder.AutoSize = true;
			this.lb_endorder.Location = new System.Drawing.Point(7, 126);
			this.lb_endorder.Name = "lb_endorder";
			this.lb_endorder.Size = new System.Drawing.Size(55, 13);
			this.lb_endorder.TabIndex = 11;
			this.lb_endorder.Text = "End Order";
			// 
			// tb_startorder
			// 
			this.tb_startorder.Location = new System.Drawing.Point(74, 97);
			this.tb_startorder.Name = "tb_startorder";
			this.tb_startorder.ReadOnly = true;
			this.tb_startorder.Size = new System.Drawing.Size(245, 20);
			this.tb_startorder.TabIndex = 10;
			// 
			// lb_startorder
			// 
			this.lb_startorder.AutoSize = true;
			this.lb_startorder.Location = new System.Drawing.Point(7, 100);
			this.lb_startorder.Name = "lb_startorder";
			this.lb_startorder.Size = new System.Drawing.Size(49, 13);
			this.lb_startorder.TabIndex = 9;
			this.lb_startorder.Text = "St. Order";
			// 
			// tb_position
			// 
			this.tb_position.Location = new System.Drawing.Point(74, 71);
			this.tb_position.Name = "tb_position";
			this.tb_position.ReadOnly = true;
			this.tb_position.Size = new System.Drawing.Size(245, 20);
			this.tb_position.TabIndex = 8;
			// 
			// lb_position
			// 
			this.lb_position.AutoSize = true;
			this.lb_position.Location = new System.Drawing.Point(7, 74);
			this.lb_position.Name = "lb_position";
			this.lb_position.Size = new System.Drawing.Size(44, 13);
			this.lb_position.TabIndex = 7;
			this.lb_position.Text = "Position";
			// 
			// tb_dateborn
			// 
			this.tb_dateborn.Location = new System.Drawing.Point(74, 45);
			this.tb_dateborn.Name = "tb_dateborn";
			this.tb_dateborn.ReadOnly = true;
			this.tb_dateborn.Size = new System.Drawing.Size(245, 20);
			this.tb_dateborn.TabIndex = 6;
			// 
			// lb_born
			// 
			this.lb_born.AutoSize = true;
			this.lb_born.Location = new System.Drawing.Point(7, 48);
			this.lb_born.Name = "lb_born";
			this.lb_born.Size = new System.Drawing.Size(54, 13);
			this.lb_born.TabIndex = 5;
			this.lb_born.Text = "Date born";
			// 
			// pb_Photo
			// 
			this.pb_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb_Photo.Location = new System.Drawing.Point(325, 19);
			this.pb_Photo.Name = "pb_Photo";
			this.pb_Photo.Size = new System.Drawing.Size(105, 124);
			this.pb_Photo.TabIndex = 2;
			this.pb_Photo.TabStop = false;
			// 
			// lb_ID
			// 
			this.lb_ID.AutoSize = true;
			this.lb_ID.Location = new System.Drawing.Point(7, 22);
			this.lb_ID.Name = "lb_ID";
			this.lb_ID.Size = new System.Drawing.Size(18, 13);
			this.lb_ID.TabIndex = 1;
			this.lb_ID.Text = "ID";
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(74, 19);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(245, 20);
			this.tb_id.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 228);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.newEmploeeToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.connectToolStripMenuItem.Text = "&Connect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.disconnectToolStripMenuItem.Text = "&Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
			// 
			// newEmploeeToolStripMenuItem
			// 
			this.newEmploeeToolStripMenuItem.Name = "newEmploeeToolStripMenuItem";
			this.newEmploeeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.newEmploeeToolStripMenuItem.Text = "&New emploee";
			this.newEmploeeToolStripMenuItem.Click += new System.EventHandler(this.newEmploeeToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::HW_CS_ADO_Connection_HR_base_.Properties.Resources.add_insert_new_plus;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "tsb_add";
			this.toolStripButton1.Click += new System.EventHandler(this.tsb_add_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::HW_CS_ADO_Connection_HR_base_.Properties.Resources.close_remove_delete;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "tsb_remove";
			this.toolStripButton2.Click += new System.EventHandler(this.tsb_remove_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::HW_CS_ADO_Connection_HR_base_.Properties.Resources.edit_make;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "tsb_edit";
			this.toolStripButton3.Click += new System.EventHandler(this.tsb_edit_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 250);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.gb_Account);
			this.Controls.Add(this.dgv_emploeers);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "HR Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_emploeers)).EndInit();
			this.gb_Account.ResumeLayout(false);
			this.gb_Account.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_emploeers;
		private System.Windows.Forms.GroupBox gb_Account;
		private System.Windows.Forms.Label lb_born;
		private System.Windows.Forms.PictureBox pb_Photo;
		private System.Windows.Forms.Label lb_ID;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.TextBox tb_position;
		private System.Windows.Forms.Label lb_position;
		private System.Windows.Forms.TextBox tb_dateborn;
		private System.Windows.Forms.TextBox tb_endorder;
		private System.Windows.Forms.Label lb_endorder;
		private System.Windows.Forms.TextBox tb_startorder;
		private System.Windows.Forms.Label lb_startorder;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newEmploeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
	}
}

