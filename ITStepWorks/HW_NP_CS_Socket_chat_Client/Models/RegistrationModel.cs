using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW_NP_CS_Socket_chat_Client.Models {
	[Serializable]
	public sealed class Registration {
		public string login { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string server { get; set; }
		[JsonIgnore]
		public string password { get; set; }
		public string token { get; private set; }

		private bool CreateToken() {
			if (String.IsNullOrEmpty(password)) return false;
			try {
				var data = Encoding.UTF8.GetBytes($"_best_{password}_chat_");
				using (SHA512 sha512 = new SHA512Managed()) {
					token = BitConverter.ToString(sha512.ComputeHash(data)).Replace("-","");
				}
				return true;
#pragma warning disable CS0168 // Variable is declared but never used
			} catch (Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used
				return false;
			}
		}

		public byte[] Register() {
			byte[] json;
			try {
				if (CreateToken()) {

					using (FileStream file = new FileStream(@"register", FileMode.Create, FileAccess.Write)) {
						json = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
						file.Write(json, 0, json.Length);
					}	
					return json;
				} else
					return new byte[0];
#pragma warning disable CS0168 // Variable is declared but never used
			} catch (Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used
				return new byte[0];
			}
		}
	}
}
