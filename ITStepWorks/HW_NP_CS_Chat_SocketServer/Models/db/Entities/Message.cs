using DB.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text;

namespace DB.Entities{
	[Table("messages")]
	public class Message: DbIdentity {

		[Column("Command")]
		[StringLength(20)]
		public string command { get; set; }

		[Column("Text")]
		[StringLength(1024)]
		public string text { get; set; }

		public User sender { get; set; }

		[Column("SenderId")]
		public long sender_id { get; set; }

		public User receiver { get; set; }

		[Column("ReceiverId")]
		public long receiver_id { get; set; }

		[Column("SendTime")]
		public DateTime sendTime { get; set; }

		[Column("ReceiveTime")]
		public DateTime viewTime { get; set; }
	}
}
