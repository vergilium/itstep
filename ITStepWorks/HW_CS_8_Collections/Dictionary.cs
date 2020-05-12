using System;
using System.Collections.Generic;
using System.Text;

namespace HW_CS_8_Collections
{

	enum language { RU_EN, EN_RU };
	class Dictionary{
		private Dictionary<string, string> m_RUEN;
		public language lang { get; set; }

		public Dictionary(language lang = language.RU_EN) {
			m_RUEN = new Dictionary<string, string>{
				{ "Дания","Denmark" },
				{ "Англия","England" },
				{ "Эстония","Estonia" },
				{ "Финляндия","Finland" },
				{ "Исландия","Iceland" },
				{ "Ирландия","Ireland" },
				{ "Латвия","Latvia" },
				{ "Норвегия","Norway" },
				{ "Шотландия","Scotland" },
				{ "Швеция","Sweden" },
				{ "Украина","Ukraine" }
			};
			this.lang = lang;
		}

		public void AddWord(string key, string value) {
			if (lang == language.RU_EN)
				m_RUEN.Add(key, value);
			else
				m_RUEN.Add(value, key);
		}
		private string GetValue(string key) {
			return m_RUEN.GetValueOrDefault(key);
		}

		private string GetKey(string value) {
			foreach (var v in m_RUEN) {
				if (v.Value.Equals(value))
					return v.Key;
			}
			return null;
		}

		public string TranslateWord(string word) {
			if(lang == language.RU_EN) {
				return this?.GetValue(word);
			} else {
				return this?.GetKey(word);
			}
		}
	}
}
