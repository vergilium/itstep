using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.ComponentModel;

namespace Phonebook_Class {

	partial class Phonebook : IEnumerator<string> {
		private int iCurrIndex;

		public string Current => lBookItem[iCurrIndex].ToString();

		object IEnumerator.Current => Current;

		public string GetLates() {
			return lBookItem?.First().ToString();
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