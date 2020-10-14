using System;
using System.Collections.Generic;
using System.Text;

namespace SocketServer.Models {
	public class UserVM {
		public long id { get; set; }
		public string login { get; set; }
		public DateTime dateLastVisit { get; set; }
		public List<MessageVM> messages { get; set; }
	}
}
