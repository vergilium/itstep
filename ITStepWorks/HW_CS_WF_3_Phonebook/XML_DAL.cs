using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HW_CS_WF_3_Phonebook {
    class XML_DAL {
        XmlDocument xmlDoc;
        public XML_DAL() :
            this("phonebook.xml") { }

        public XML_DAL(string path) {
            try {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
            } catch (FileNotFoundException) {
                MessageBox.Show("File is not found!");
            } finally {

            }
        }

        public bool SaveFile(ref object odj) {
            return true;
        }

        public bool OpenFile(out object obj) {
            obj = new object();
            return true;
        }
        

    }
}
