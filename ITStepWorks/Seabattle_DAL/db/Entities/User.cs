using DB.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entities {
	[Table("users")]
	public class User : DbIdentity<int> {

		[Column("Login")]
		[StringLength(32)]
		public string login { get; set; }

		[Column("FirstName")]
		[StringLength(32)]
		public string firstName { get; set; }

		[Column("LastName")]
		[StringLength(32)]
		public string lastName { get; set; }

		[Column("Token")]
		[StringLength(128)]
		public string token { get; set; }

		[Column("Mail")]
		[StringLength(50)]
		public string mail { get; set; }

		[Column("Password")]
		[StringLength(256)]
		public string pswd { get; set; }

		[Column("DateRegistration")]
		public DateTime dateReg { get; set; }
		[Column("DateLastVisit")]
		public DateTime dateLastVisit { get; set; }

		public List<RoomPlayers> roomPlayer { get; set; }
	}
}
