using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Data_Access_Layer {
	class XML : IDataLayer, IDisposable {
        XmlDocument xmlDoc;
        public XML() :
            this("phonebook.xml") { }

        public XML(string path) {
            try {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(path);
            } catch (FileNotFoundException) {
                MessageBox.Show("File is not load!");
            } finally {

            }
        }

        public void Dispose() {
            xmlDoc = null;
        }

        public bool OpenFile(string path, out object data) {
            throw new NotImplementedException();
        }

        public bool SaveFile(string path, ref object data) {
            throw new NotImplementedException();
        }
    }
}
