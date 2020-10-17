using System;
using System.Collections.Generic;
using System.Text;

namespace SocketServer.Models {
	[Serializable]
	public class MSG {
		public Guid id { get => Guid.NewGuid(); set { id = value; } }
		public string command { get; set; }
		public string text { get; set; }
		public DateTime sendTime { get => DateTime.Now; }
		public DateTime viewTime { get; set; }
	}
}
