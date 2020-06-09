using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using Phonebook_Class;
using HW_CS_WF_3_Phonebook;

namespace Data_Access_Layer {
    public interface IDataLayer {
        bool OpenFile(out object data);
        bool SaveFile(ref object data);
    }

    class DAL {
        private static List<string> sFileTypes;
        public static int cFileTypesCount { get; private set; }
        public DAL() {
            sFileTypes = new List<string>() { 
                "XML"
            };  
        }

        public static string GetFilterTypes() {
            if (sFileTypes is null)  return null; 
            else {
                StringBuilder sb = new StringBuilder();
                foreach (var s in sFileTypes) {
                    sb.Insert(sb.Length, $"{s} files(*.{s.ToLower()})|*.{s.ToLower()}|");
                }
                sb.Insert(sb.Length, "All files(*.*)|*.*");
             return sb.ToString(); 
            }
        }

        public static int GetFilterTypesCount() {
            return sFileTypes.Count+1;
        }

        public bool LoadFile(string path, out object data) {
            data = default;
            switch (Path.GetExtension(path).Trim('.')) {
                case "xml":
                    using (XML<Phonebook> xml = new XML<Phonebook>(path)) {
                        xml.OpenFile(out data);
                    }
                    break;
                default: return false;
            }
            return true;
        }
  
        public bool SaveFile(string path, ref object data) {
            switch (Path.GetExtension(path).Trim('.')) {
                case "xml": using (XML<Phonebook> xml = new XML<Phonebook>(path)) {
                        xml.SaveFile(ref data);
                    } break;
                default: return false;
            }
            return true;
        }
    }
}
