using System;
using System.IO;
using System.Xml.Serialization;

namespace Data_Access_Layer {
    class XML<T> : IDataLayer, IDisposable{

        private string sPath;
        XmlSerializer xmlFormat;
        public XML() :
            this("phonebook.xml") { }

        public XML(string path) {
            xmlFormat = new XmlSerializer(typeof(T));
            sPath = path;
        }

        public void Dispose() {
            xmlFormat = null;
        }

        public bool OpenFile(out object data) {
            data = default(T);
            try {
                using (Stream fStream = File.OpenRead(sPath)) {
                data = (T)xmlFormat.
                Deserialize(fStream);
            }
                return true;
            } catch { return false; }
        }

        public bool SaveFile(ref object data) {
            try {
                using (Stream fStream = File.Create(sPath)) {
                    xmlFormat.Serialize(fStream, data);
                }
                return true;
            } catch { return false; }
        }
    }
}
