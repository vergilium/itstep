using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW_CS_10_Serialization {
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
            sPhone = new List<string>();
            sPhone.Add(phone);
            sDescription = descr;
        }
    }
    class Phonebook {

        private Dictionary<Guid, BOOKITEM> lBookItem;
        private const string sPhonePattern = @"((\+38|8|\+3|\+ )[ ]?)?([(]?\d{3}[)]?[\- ]?)?(\d[ -]?){6,14}";
        protected Phonebook() {
            lBookItem = new Dictionary<Guid, BOOKITEM>();
        }
        protected Phonebook(Dictionary<Guid, BOOKITEM> data) {
            lBookItem = data;
        }

        public bool AddItem(string fname, string lname, string sname, string phone, string descr) {
            if (Regex.IsMatch(phone, sPhonePattern)) {
                lBookItem.Add(Guid.NewGuid(), new BOOKITEM(fname, lname, sname, phone, descr));
                return true;
            } else return false;
        }

        public bool AddPhone(Guid key, string phone) {
            if (Regex.IsMatch(phone, sPhonePattern)) {
                lBookItem[key].sPhone.Add(phone);
                return true;
            } else return false;
        }

        public bool DelItem(Guid key) => lBookItem.Remove(key);

        public void ClearBook() => lBookItem.Clear();

        public void DelPhone(Guid key, string phone) => lBookItem[key].sPhone.Remove(phone);


    }
}
