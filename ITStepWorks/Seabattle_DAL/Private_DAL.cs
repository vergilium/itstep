using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Seabattle {
	public static partial class DAL {
		private static string GetHash512(string str) {
			byte[] data = Encoding.UTF8.GetBytes($"_best_{str}_game_"); ;
			string result;
			using (SHA512 shaM = new SHA512Managed()) {
				result = BitConverter.ToString(shaM.ComputeHash(data)).Replace("-", "");
			}
			return result;
		}

		private static string GetToken(string login, string pswd) {
			return GetHash512($"{login}:{pswd}:{DateTime.Now}:Secret");
		}
	}
}
