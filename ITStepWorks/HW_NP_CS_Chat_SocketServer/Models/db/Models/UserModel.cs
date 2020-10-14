using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SocketServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB.Models {
	public class UserModel {
		public long id { get; set; }
		public string login { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string token { get; set; }
		public DateTime dateReg { get; set; }
		public DateTime dateLastVisit { get; set; }
		public List<MessageModel> messages { get; set; }

		public UserModel(User usr) {
			id = usr.Id;
			login = usr.login;
			firstName = usr.firstName;
			lastName = usr.lastName;
			token = usr.token;
			dateReg = usr.dateReg;
			dateLastVisit = usr.dateLastVisit;
			messages = usr.messages
				.Select(msg => new MessageModel(msg)).ToList();
		}

		public static implicit operator UserVM(UserModel model) {
			return new UserVM {
				id = model.id,
				login = model.login,
				dateLastVisit = model.dateLastVisit,
				messages = model.messages
					.Select(m => new MessageVM {
						id = m.id,
						text = m.text,
						sendTime = m.sendTime,
						viewTime = m.viewTime
					}).ToList()
			}
		}

		public static IEnumerable<UserModel> GetAllUsers() {
			return Unit.UserRepository.AllItems
				.Include(u => u.Id)
				.Include(u => u.login)
				.Include(u => u.firstName)
				.Include(u => u.lastName)
				.Include(u => u.token)
				.Include(u => u.dateReg)
				.Include(u => u.dateLastVisit)
				.Select(u => new UserModel(u))
				.ToList();
		}

		public static IEnumerable<UserVM> GetAllUsersVM() {
			return Unit.UserRepository.AllItems
				.Include(u => u.Id)
				.Include(u => u.login)
				.Include(u => u.dateLastVisit)
				.Include(u => u.messages)
				.Select(u => (UserVM) new UserModel(u))
				.ToList();
		}
	}


}
