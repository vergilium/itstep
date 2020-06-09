using Phonebook_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_CS_WF_3_Phonebook
{
    public partial class MainForm : Form
    {
        Data_Access_Layer.DAL dataLayer = new Data_Access_Layer.DAL();
        Phonebook_Class.Phonebook phBook;

        public MainForm()
        {
            InitializeComponent();
            btn_NewItem.Tag = 0;
            openFileDialog.Filter = Data_Access_Layer.DAL.GetFilterTypes();
            openFileDialog.FilterIndex = Data_Access_Layer.DAL.cFileTypesCount;
            saveFileDialog.Filter = Data_Access_Layer.DAL.GetFilterTypes();
            saveFileDialog.FilterIndex = Data_Access_Layer.DAL.cFileTypesCount;
        }

        private void textBoxs_New_Enable(bool en) {
            text_Name.Enabled = en;
            text_LName.Enabled = en;
            text_SName.Enabled = en;
            text_Phone.Enabled = en;
            text_Descr.Enabled = en;
        }

        private void btn_NewItem_Click(object sender, EventArgs e) {
            if (btn_NewItem.Tag.Equals(0)) {
                textBoxs_New_Enable(true);
                btn_NewItem.Text = "Добавить";
                btn_NewItem.Tag = 1;
            } else {
                phBook.AddItem(text_Name.Text, text_SName.Text, text_LName.Text, text_Phone.Text, text_Descr.Text);
                btn_NewItem.Text = "Новый";
                textBoxs_New_Enable(false);
                btn_NewItem.Tag = 0;
            }
           
        }

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            else {
               dataLayer.LoadFile(openFileDialog.FileName, out object obj);
                phBook = obj as Phonebook;
            }
        }

        private void SaveAs_ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            else {
                object obj = phBook;
                dataLayer.SaveFile(saveFileDialog.FileName, ref obj);
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            phBook = new Phonebook_Class.Phonebook();
            mainList.DataSource = phBook.lBookItem;
        }
    }
}
