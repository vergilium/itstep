using DB.Models;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Seabattle {
	public static partial class DAL {
		private static ILogger logger = LoggerFactory.Create(builder => {
			builder.SetMinimumLevel(LogLevel.Trace);
			builder.AddConsole();
		}).CreateLogger("DAL");

		public static void Logger(ILogger log) {
			logger = log;
		}

		public static async Task<string> Registration(string login, string fname, string lname, string mail, string pswd) {
			//Trace
			logger.LogTrace("Enter Registration method with parameters {0} : {1} : {2} : {3} : {4}", login, fname, lname, mail, pswd);
			string token;
			try {
				if (pswd.Length < 256) pswd = GetHash512(pswd);
				token = GetToken(login, pswd);
				await UserModel.PutUser(login, fname, lname, mail, token, pswd);
			} catch (Exception ex) {
				logger.LogError(ex.Message);
				token = null;
			}

			return token;
		}

		public static async Task<string> Registration(object data) {
			MSGModel user = (MSGModel)Convert.ChangeType(data, typeof(MSGModel));

			//Trace
			logger.LogTrace("Enter Registration method with parameters {0} : {1} : {2} : {3} : {4}", user.login, user.firstName, user.lastName, user.mail, user.pswd);
			string token;
			try {
				if (user.pswd.Length < 256) user.pswd = GetHash512(user.pswd);
				token = GetToken(user.login, user.pswd);
				await UserModel.PutUser(user.login, user.firstName, user.lastName, user.mail, token, user.pswd);
			} catch (Exception ex) {
				logger.LogError(ex.Message);
				token = null;
			}

			return token;
		}

		public static bool Autorization(string login, string pswd, ref object user) {
			//Trace
			logger.LogTrace("Enter Autorization method with parameters {0} : {1} : {2} ", login, pswd, user);
			try {
				if (pswd.Length < 256) pswd = GetHash512(pswd);
				user = UserModel.GetUser(login, pswd);

				if (user == null) {
					logger.LogTrace("Method Autorization user not found!!!");
					return false;
				} else {
					logger.LogTrace("Method Autorization UserModel : id {0}, login {1}, mail {2}, DateRegistration {3};", (user as UserModel).id, (user as UserModel).login, (user as UserModel).mail, (user as UserModel).dateReg);
					return true;
				}
			} catch (Exception ex) {
				logger.LogError(ex.Message);
				logger.LogTrace(ex.StackTrace);
				return false;
			}

		}

		public static bool Autorization(string token, ref object user) {
			//Trace
			logger.LogTrace("Enter Autorization method with parameters token = {0} ", token);
			try {
				user = UserModel.GetUser(token);
				if (user == null) {
					logger.LogTrace("Method Autorization user not found!!!");
					return false;
				} else {
					logger.LogTrace("Method Autorization UserModel : id {0}, login {1}, mail {2}, DateRegistration {3};", (user as UserModel).id, (user as UserModel).login, (user as UserModel).mail, (user as UserModel).dateReg);
					return true;
				}
			} catch (Exception ex) {
				logger.LogError(ex.Message);
				logger.LogTrace(ex.StackTrace);
				return false;
			}
		}


	}
}
