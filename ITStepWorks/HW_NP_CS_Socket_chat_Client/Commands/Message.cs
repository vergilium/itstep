using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands {
	[Serializable]
	public abstract class MSG {
		public Guid id { get; private set; }
		public string command { get; private set; }
		public string text { get; private set; }
		public DateTime sendTime { get; private set; }
		public MSG(Guid id, string cmd, string txt, DateTime time) {
			this.id = id;
			command = cmd;
			text = txt;
			sendTime = time;
		}
	}
}
