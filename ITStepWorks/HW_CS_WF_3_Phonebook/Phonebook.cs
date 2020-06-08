using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;

namespace Phonebook_Class {

	#region struct BOOKITEM
	internal struct BOOKITEM {
		public string sFName { get; set; }
		public string sLName { get; set; }
		public string sSName { get; set; }
		public List<string> sPhone { get; set; }
		public string sDescription { get; set; }

		public BOOKITEM(string fname, string lname, string sname, string phone, string descr) {
			sFName = fname;
			sLName = lname;
			sSName = sname;
			sPhone = new List<string>() { phone };
			sDescription = descr;
		}

		public override string ToString() {
			StringBuilder str = new StringBuilder($"{sFName} {sLName} {sSName} {sDescription}");
			foreach (string item in sPhone) {
				str.Insert(str.Length, item);
			}
			return str.ToString();
		}
	}

	#endregion

	#region class PBBindingList
	public class PBookBindingList<T> : BindingList<T> {
		List<T> list;
		public PBookBindingList(int count = 0) {
			list = new List<T>(count);
		}

		public void Sort() {
			list.Sort();
			ResetBindings();
		}
	}
	#endregion
	partial class Phonebook {

		private PBookBindingList<BOOKITEM> lBookItem;

		private const string sPhonePattern = @"((\+38|8|\+3|\+ )[ ]?)?([(]?\d{3}[)]?[\- ]?)?(\d[ -]?){6,14}";

		public Phonebook() {
			lBookItem = new PBookBindingList<BOOKITEM>();
		}

		public PBookBindingList<BOOKITEM> GetData() => lBookItem;

		public void DelItem(int key) => lBookItem.RemoveAt(key);

		public void ClearBook() => lBookItem.Clear();

		public void DelPhone(int key, string phone) => lBookItem[key].sPhone.Remove(phone);

		public int GetCount() => lBookItem.Count();

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
	}
}
