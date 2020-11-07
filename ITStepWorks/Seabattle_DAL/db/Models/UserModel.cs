using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Models {
	public class UserModel {
		public int id { get; set; }
		public string login { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string mail { get; set; }
		public DateTime dateReg { get; set; }
		public DateTime dateLastVisit { get; set; }
		//public List<MessageModel> messages { get; set; }

		public UserModel(User usr) {
			id = usr.Id;
			login = usr.login;
			firstName = usr.firstName;
			lastName = usr.lastName;
			mail = usr.mail;
			dateReg = usr.dateReg;
			dateLastVisit = usr.dateLastVisit;
			//messages = usr.messages
			//	.Select(msg => new MessageModel(msg)).ToList();
		}

		//public static implicit operator UserVM(UserModel model) {
		//	return new UserVM
		//	{
		//		id = model.id,
		//		login = model.login,
		//		dateLastVisit = model.dateLastVisit,
		//		//messages = model.messages
		//		//	.Select(m => new MessageVM
		//		//	{
		//		//		id = m.id,
		//		//		text = m.text,
		//		//		sendTime = m.sendTime,
		//		//		viewTime = m.viewTime
		//		//	}).ToList()
		//	};
		//}

		public static IEnumerable<UserModel> GetAllUsers() {
			return Unit.UserRepository.AllItems
				.Include(u => u.Id)
				.Include(u => u.login)
				.Include(u => u.firstName)
				.Include(u => u.lastName)
				.Include(u => u.mail)
				.Include(u => u.dateReg)
				.Include(u => u.dateLastVisit)
				.Select(u => new UserModel(u))
				.ToList();
		}

		//public static IEnumerable<UserVM> GetAllUsersVM() {
		//	return Unit.UserRepository.AllItems
		//		.Include(u => u.Id)
		//		.Include(u => u.login)
		//		.Include(u => u.dateLastVisit)
		//		.Select(u => (UserVM) new UserModel(u))
		//		.ToList();
		//}

		public static async Task<int> PutUser(
				string login,
				string fname,
				string lname,
				string email,
				string token,
				string pswd) {
			return await Unit.UserRepository.AddItemAsync(
				new User {
				login = login,
				firstName = fname,
				lastName = lname,
				mail = email,
				token = token,
				pswd = pswd,
				dateReg = DateTime.Now,
				dateLastVisit = DateTime.Now}
			);
		}

		public static UserModel GetUser(string login, string pswd) {
			return Unit.UserRepository.AllItems
				.Where(u => u.login.Contains(login) && u.pswd.Contains(pswd))
				.Select(u => new UserModel(u))
				.SingleOrDefault();
		}

		public static UserModel GetUser(string token) {
			return (UserModel)Unit.UserRepository.AllItems
				.Include(u => u.Id)
				.Include(u => u.login)
				.Include(u => u.firstName)
				.Include(u => u.lastName)
				.Include(u => u.mail)
				.Include(u => u.dateReg)
				.Include(u => u.dateLastVisit)
				.Where(u => u.token == token)
				.Select(u => new UserModel(u));
		}
	}


}
