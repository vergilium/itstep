using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.Remoting.Messaging;

namespace Phonebook_Class {

	#region struct BOOKITEM
	internal struct BOOKITEM {
        public string sFName { get;  set; }
        public string sLName { get;  set; }
        public string sSName { get;  set; }
        public List<string> sPhone { get;  set; }
        public string sDescription { get; set; }

        public BOOKITEM(string fname, string lname, string sname, string phone, string descr) {
            sFName = fname;
            sLName = lname;
            sSName = sname;
            sPhone = new List<string>() { phone };
            sDescription = descr;
        }

        public string[] toArray() {
            return new string[] {sFName, sLName, sSName, sDescription }.Concat(sPhone).ToArray();
        }
    }

	#endregion

	class Phonebook : IEnumerator<string[]> {

        private List<BOOKITEM> lBookItem;
        private int iCurrIndex;

        private const string sPhonePattern = @"((\+38|8|\+3|\+ )[ ]?)?([(]?\d{3}[)]?[\- ]?)?(\d[ -]?){6,14}";

        public string[] Current => lBookItem[iCurrIndex].toArray();

        object IEnumerator.Current => Current;

        public void DelItem(int key) => lBookItem.RemoveAt(key);

        public void ClearBook() => lBookItem.Clear();

        public void DelPhone(int key, string phone) => lBookItem[key].sPhone.Remove(phone);

        public Phonebook() {
            lBookItem = new List<BOOKITEM>();
        }
        public Phonebook(List<BOOKITEM> data) {
            lBookItem = data;
        }

        public string[] GetLates() {
            return lBookItem?.First().toArray();
        }

        public bool AddItem(string fname, string lname, string sname, string phone, string descr) {
            if (Regex.IsMatch(phone, sPhonePattern)) {
                lBookItem.Add(new BOOKITEM(fname, lname, sname, phone, descr));
                return true;
            } else return false;
        }

        public bool AddPhone(int key, string phone) {
            if (Regex.IsMatch(phone, sPhonePattern)) {
                lBookItem[key].sPhone.Add(phone);
                return true;
            } else return false;
        }

        public void Dispose() {
            lBookItem.Clear();
        }

        public bool MoveNext() {
            if (iCurrIndex < lBookItem.Count - 1) {
                iCurrIndex++;
                return true;
            } else return false;
        }

        public void Reset() {
            iCurrIndex = -1;
        }
    }
}
