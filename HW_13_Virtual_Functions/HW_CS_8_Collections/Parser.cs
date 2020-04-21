using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HW_CS_8_Collections {
	class Parser : IDisposable {
		public Dictionary<String, int> ParsCounter { get; private set; }
		private StreamReader file { get; set; }

		public Parser(string path) {
			try {
				file = new StreamReader(path, System.Text.Encoding.Default);
				ParsCounter = new Dictionary<string, int>();
			} catch (FileNotFoundException e) {
				Console.WriteLine(e.Message);
			}
		}

		public void ParsText() {
			Queue<char> word = new Queue<char>();
			string[] tempStr;
			char[] delimiterChars = { ' ', ',', '.', ':', '\t', '<', '>', '(', ')' };
			while (file.EndOfStream == false) {
				tempStr = file.ReadLine()?.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
				for (uint i = 0; i < tempStr.Length; ++i) {
					if (ParsCounter.ContainsKey(tempStr[i])) {
						ParsCounter[tempStr[i]] = ParsCounter.GetValueOrDefault(tempStr[i]) + 1;
					} else {
						ParsCounter.Add(tempStr[i], 1);
					}
				}
			}
		}

		public override string ToString() {
			StringBuilder str = new StringBuilder("Parser [word;counter]\n");
			foreach(var v in ParsCounter) {
				str.Insert(str.Length, $"[{v.Key},{v.Value}]\n");
			}
			return str.ToString();
		}

		public void Dispose() {
			file.Close();
			file.Dispose();
		}
	}
}
