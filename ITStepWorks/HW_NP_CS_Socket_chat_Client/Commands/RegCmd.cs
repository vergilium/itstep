using Commands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_NP_CS_Socket_chat_Client.Commands {
	public class RegCmd : MSG {
		public RegCmd(CommandBilder obj):base(obj.id, obj.command, obj.text, obj.sendTime) {
		}

		public byte[] getCommand() {
			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
		}
	}
}
