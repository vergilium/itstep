using HW_NP_CS_Socket_chat_Client.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands {
	public class RegCmdBuilder : CommandBilder {
		public RegCmdBuilder(string text) : base(CMDs.Registration) { }
		public override MSG Create() {
			return new RegCmd(this);
		}
	}
}
