using DB.Entities;
using DB.Models;
using Newtonsoft.Json;
using SocketServer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.Commands {
	public class RegistrationCommand {
		public static async Task<bool> GoRegistration(MSG msg) {
			try {
				User user = JsonConvert.DeserializeObject<User>(msg.text);
				await Task.Run(() => UserModel.PutUser(user));
				return true;
#pragma warning disable CS0168 // Variable is declared but never used
			} catch(Exception ex) {
#pragma warning restore CS0168 // Variable is declared but never used

				return false;
			}
		}

	}
}
