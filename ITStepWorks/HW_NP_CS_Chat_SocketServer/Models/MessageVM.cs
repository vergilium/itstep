using System;
using System.Collections.Generic;
using System.Text;

namespace SocketServer.Models {
	public class MessageVM {
		public long id { get; set; }
		public string text { get; set; }
		public DateTime sendTime { get; set; }
		public DateTime viewTime { get; set; }
	}
}
