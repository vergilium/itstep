using DB.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entities {
	[Table("users")]
	public class User : DbIdentity {

		[Column("Login")]
		[StringLength(32)]
		public string login { get; set; }

		[Column("FirstName")]
		[StringLength(32)]
		public string firstName { get; set; }

		[Column("LastName")]
		[StringLength(32)]
		public string lastName { get; set; }

		[Column("Key")]
		[StringLength(128)]
		public string token { get; set; }
		[Column("DateRegistration")]
		public DateTime dateReg { get; set; }
		[Column("DateLastVisit")]
		public DateTime dateLastVisit { get; set; }

		public List<Message> messages { get; set; }
	}
}
