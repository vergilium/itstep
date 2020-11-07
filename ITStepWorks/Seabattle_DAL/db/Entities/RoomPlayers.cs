using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entities {
	[Table("room_authors")]
	public class RoomPlayers {

		[Column("player_id")]
		public int player_id { get; set; }

		[Column("room_id")]
		public int room_id { get; set; }

		public User player { get; set; }
		public Room room { get; set; }
	}
}
