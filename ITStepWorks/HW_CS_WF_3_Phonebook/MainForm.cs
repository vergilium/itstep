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
        Phonebook phBook = new Phonebook();
        public MainForm()
        {
            InitializeComponent();
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

        private void MainList_Enter(object sender, EventArgs e) {
            MainList.Lines = phBook.GetLates();
        }
    }
}
