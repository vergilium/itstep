using DB.Models;
using System;
using System.Threading.Tasks;

namespace Seabattle {
	public static partial class DAL {
		public static async Task<string> Registration(string login, string fname, string lname, string mail, string pswd) {
			if(pswd.Length < 256 ) pswd = GetHash512(pswd);
			string token = GetToken(login, pswd);
			await UserModel.PutUser(login, fname, lname, mail, token, pswd);
			return token;
		}
		public static bool Autorization(string login, string pswd, ref UserModel user) {
			try {
				if (pswd.Length < 256) pswd = GetHash512(pswd);
				user = UserModel.GetUser(login, pswd);
				Console.WriteLine(user);
				if(user == null) {
					return false;
				}else
					return true;
#pragma warning disable CS0168 // Variable is declared but never used
			} catch (Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used
				return false;
			}
			
		} 

		public static bool Autorization(string token, ref UserModel user) {
			try {
				user = UserModel.GetUser(token);
				Console.WriteLine(user);
				if (user == null) {
					return false;
				} else
					return true;
#pragma warning disable CS0168 // Variable is declared but never used
			} catch (Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used
				return false;
			}
		}


	}
}
