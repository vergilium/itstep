using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models {
	class MSGModel {
		public string login { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string mail { get; set; } = null;
		public string token { get; set; } = null;
		public string pswd { get; set; } = null;

	}
}
