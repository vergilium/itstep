using DB.Models;
using Newtonsoft.Json;
using SocketServer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer.Commands {

	public class AutorizationCommand {
		public static async Task<bool> GoAutorization(MSG msg) {
			try {
				
				return  true;
			} catch {
				return false;
			}
		}
	}
}
