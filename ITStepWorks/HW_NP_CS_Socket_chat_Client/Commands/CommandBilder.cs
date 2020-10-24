using System;


namespace Commands {
	public enum CMDs : uint { Registration, Autorization, SendMessage, Disconnect };
	public abstract class CommandBilder {
		public  Guid id { get; private set; }
		public string command { get; private set; }
		public string text { get; set; }
		public DateTime sendTime { get; private set; }

		public CommandBilder(CMDs cmd) {
			id = Guid.NewGuid();
			command = Enum.GetName(typeof(CMDs), cmd);
			sendTime = DateTime.Now;
		}

		abstract public MSG Create();
	}
}
