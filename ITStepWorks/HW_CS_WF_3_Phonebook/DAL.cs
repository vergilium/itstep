using Phonebook_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Data_Access_Layer {
    public interface IDataLayer {
        bool OpenFile(string path, out object data);
        bool SaveFile(string path, ref object data);
    }
    class DAL {
        private static List<Type> sFileTypes;
        public static int cFileTypesCount { get; private set; }
        public DAL() {
            sFileTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace == "Data_Access_Layer" && t.Name != "DAL" && t.Name != "IDataLayer").ToList();  
        }

        public static string GetFilterTypes() {
            if (sFileTypes is null)  return null; 
            else {
                StringBuilder sb = new StringBuilder();
                foreach (var s in sFileTypes) {
                    sb.Insert(sb.Length, $"{s.Name} files(*.{s.Name.ToLower()})|*.{s.Name.ToLower()}|");
                }
                sb.Insert(sb.Length, "All files(*.*)|*.*");
             return sb.ToString(); 
            }
        }
        public static int GetFilterTypesCount() {
            return sFileTypes.Count+1;
        }

        public bool LoadFile(string path, out Phonebook data) {
            data = new Phonebook();
            return true;
        }
        /// <summary>
        /// НУЖНО ДОДЕЛАТЬ: ВЫЗОВ НУЖНОГО КОНСТРУКТОРА В ЗАВИСИМОСТИ ОТ ТИПА
        /// </summary>
        /// <param name="path"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SaveFile(string path, ref Phonebook data) {
            object targetObject = Activator.CreateInstance(sFileTypes[sFileTypes.IndexOf(sFileTypes.Find(a => a.Name == Path.GetExtension(path).Trim('.')))]);
            return true;
        }
    }
}
