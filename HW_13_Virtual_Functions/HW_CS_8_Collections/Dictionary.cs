using System;
using System.Collections.Generic;
using System.Text;

namespace HW_CS_8_Collections
{
	class Dictionary{
		private Dictionary<string, string> m_RUEN;
		private Dictionary<string, string> m_ENRU;
		public int language { 
			get => language;
			set {
				if (language < 0 && language > 1)
					throw new System.ArgumentException("Language must be in the range between 0 and 1");
				else language = value;
			} 
		}

		public Dictionary(int lang = 0) {
			m_RUEN = new Dictionary<string, string>();
			m_ENRU = new Dictionary<string, string>();
			language = lang;
		}

		public void AddWord(string key, string value) {
			m_lpDict.Add(key, value);
		}
		public string GetValue(string key) {
			return m_lpDict.GetValueOrDefault(key);
		}

		public string GetKey(string value) {
			return m_lpDict.
		}
	}
}
