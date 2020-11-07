using DB.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DB.Entities {
	[Table("rooms")]
	public class Room : DbIdentity<int> {

		[Column("roomName")]
		[StringLength(20)]
		public string name { get; set; }

		[Column("typeId")]
		public int type_id { get; set; }

		[Column("gameId")]
		public int game_id { get; set; }

		[Column("dateCreate")]
		public DateTime createDate { get; set; }

		[Column("dateClose")]
		public DateTime closeDate { get; set; }

		public List<Battle> battles { get; set; }
		public List<RoomPlayers> roomPlayers { get; set; }
	}
}
