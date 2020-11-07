using DB.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Threading.Tasks;

namespace Seabattle {
	class Program {
		
	static void Main(string[] args) {
			object user = new MSGModel { firstName = "Alex", lastName = "Maloivan", login = "Vergilium", pswd = "Maloivan123", mail = "", token = "" };
			DAL.Registration(user).Wait();
				//DAL.Registration("Vergilium", "Alex", "Maloivan", null, "Maloivan123").Wait();
				//object user = null;
				//Console.WriteLine(DAL.Autorization("Vergilium", "Maloivan123", ref user));
			}
	}
}
