namespace HW_CS_WF_3_Phonebook
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_NewItem = new System.Windows.Forms.Button();
			this.btn_AddPhone = new System.Windows.Forms.Button();
			this.btn_EditItem = new System.Windows.Forms.Button();
			this.MainList = new System.Windows.Forms.TextBox();
			this.text_Name = new System.Windows.Forms.TextBox();
			this.text_LName = new System.Windows.Forms.TextBox();
			this.text_SName = new System.Windows.Forms.TextBox();
			this.text_Phone = new System.Windows.Forms.TextBox();
			this.text_Descr = new System.Windows.Forms.TextBox();
			this.phonebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.MainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(784, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "top menu";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_ToolStripMenuItem,
            this.SaveAs_ToolStripMenuItem,
            this.Exit_ToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// Open_ToolStripMenuItem
			// 
			this.Open_ToolStripMenuItem.Name = "Open_ToolStripMenuItem";
			this.Open_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.Open_ToolStripMenuItem.Text = "Открыть";
			// 
			// SaveAs_ToolStripMenuItem
			// 
			this.SaveAs_ToolStripMenuItem.Name = "SaveAs_ToolStripMenuItem";
			this.SaveAs_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.SaveAs_ToolStripMenuItem.Text = "Сохранить как";
			// 
			// Exit_ToolStripMenuItem
			// 
			this.Exit_ToolStripMenuItem.Name = "Exit_ToolStripMenuItem";
			this.Exit_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.Exit_ToolStripMenuItem.Text = "Выход";
			// 
			// btn_NewItem
			// 
			this.btn_NewItem.Location = new System.Drawing.Point(12, 27);
			this.btn_NewItem.Name = "btn_NewItem";
			this.btn_NewItem.Size = new System.Drawing.Size(75, 23);
			this.btn_NewItem.TabIndex = 1;
			this.btn_NewItem.Tag = "0";
			this.btn_NewItem.Text = "Новый";
			this.btn_NewItem.UseVisualStyleBackColor = true;
			this.btn_NewItem.Click += new System.EventHandler(this.btn_NewItem_Click);
			// 
			// btn_AddPhone
			// 
			this.btn_AddPhone.Location = new System.Drawing.Point(93, 27);
			this.btn_AddPhone.Name = "btn_AddPhone";
			this.btn_AddPhone.Size = new System.Drawing.Size(75, 23);
			this.btn_AddPhone.TabIndex = 2;
			this.btn_AddPhone.Text = "Доб. Тел.";
			this.btn_AddPhone.UseVisualStyleBackColor = true;
			// 
			// btn_EditItem
			// 
			this.btn_EditItem.Location = new System.Drawing.Point(174, 27);
			this.btn_EditItem.Name = "btn_EditItem";
			this.btn_EditItem.Size = new System.Drawing.Size(75, 23);
			this.btn_EditItem.TabIndex = 3;
			this.btn_EditItem.Text = "Изменить";
			this.btn_EditItem.UseVisualStyleBackColor = true;
			// 
			// MainList
			// 
			this.MainList.Location = new System.Drawing.Point(12, 83);
			this.MainList.Multiline = true;
			this.MainList.Name = "MainList";
			this.MainList.Size = new System.Drawing.Size(760, 306);
			this.MainList.TabIndex = 4;
			this.MainList.Enter += new System.EventHandler(this.MainList_Enter);
			// 
			// text_Name
			// 
			this.text_Name.Enabled = false;
			this.text_Name.Location = new System.Drawing.Point(12, 56);
			this.text_Name.Name = "text_Name";
			this.text_Name.Size = new System.Drawing.Size(100, 20);
			this.text_Name.TabIndex = 5;
			this.text_Name.Text = "Имя";
			// 
			// text_LName
			// 
			this.text_LName.Enabled = false;
			this.text_LName.Location = new System.Drawing.Point(118, 56);
			this.text_LName.Name = "text_LName";
			this.text_LName.Size = new System.Drawing.Size(100, 20);
			this.text_LName.TabIndex = 6;
			this.text_LName.Text = "Фамилия";
			// 
			// text_SName
			// 
			this.text_SName.Enabled = false;
			this.text_SName.Location = new System.Drawing.Point(224, 56);
			this.text_SName.Name = "text_SName";
			this.text_SName.Size = new System.Drawing.Size(100, 20);
			this.text_SName.TabIndex = 7;
			this.text_SName.Text = "Отчество";
			// 
			// text_Phone
			// 
			this.text_Phone.Enabled = false;
			this.text_Phone.Location = new System.Drawing.Point(330, 56);
			this.text_Phone.Name = "text_Phone";
			this.text_Phone.Size = new System.Drawing.Size(100, 20);
			this.text_Phone.TabIndex = 8;
			this.text_Phone.Text = "Телефон";
			// 
			// text_Descr
			// 
			this.text_Descr.Enabled = false;
			this.text_Descr.Location = new System.Drawing.Point(436, 56);
			this.text_Descr.Name = "text_Descr";
			this.text_Descr.Size = new System.Drawing.Size(336, 20);
			this.text_Descr.TabIndex = 9;
			this.text_Descr.Text = "Описание";
			// 
			// phonebookBindingSource
			// 
			this.phonebookBindingSource.DataSource = typeof(HW_CS_WF_3_Phonebook.Phonebook);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 401);
			this.Controls.Add(this.text_Descr);
			this.Controls.Add(this.text_Phone);
			this.Controls.Add(this.text_SName);
			this.Controls.Add(this.text_LName);
			this.Controls.Add(this.text_Name);
			this.Controls.Add(this.MainList);
			this.Controls.Add(this.btn_EditItem);
			this.Controls.Add(this.btn_AddPhone);
			this.Controls.Add(this.btn_NewItem);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "PhoneBook";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.phonebookBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Exit_ToolStripMenuItem;
		private System.Windows.Forms.Button btn_NewItem;
		private System.Windows.Forms.Button btn_AddPhone;
		private System.Windows.Forms.Button btn_EditItem;
		private System.Windows.Forms.BindingSource phonebookBindingSource;
		private System.Windows.Forms.TextBox MainList;
		private System.Windows.Forms.TextBox text_Name;
		private System.Windows.Forms.TextBox text_LName;
		private System.Windows.Forms.TextBox text_SName;
		private System.Windows.Forms.TextBox text_Phone;
		private System.Windows.Forms.TextBox text_Descr;
	}
}

