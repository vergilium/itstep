using DB.Domain;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public enum CellStatus:int { Wather, ShipDeck, DeckLose, HitLose };

namespace DB.Entities {
	[Table("battels")]
	public class Battle : DbIdentity<int> {
		[Column("roomId")]
		public int room_id { get; set; }
		public Room room { get; set; }

		[Column("field_1")]
		[StringLength(1024)]
		public string _field_1 { get; set; }

		[Column("field_2")]
		[StringLength(1024)]
		public string _field_2 { get; set; }

		[Column("result")]
		public int result { get; set; }

		[Column("winSteps")]
		public int steps { get; set; }

		[Column("timeStart")]
		public DateTime startTime { get; set; }

		[Column("timeEnd")]
		public DateTime endTime { get; set; }

		[NotMapped]
		public CellStatus[,] field_1 {
			get { return _field_1 == null ? null : JsonConvert.DeserializeObject<CellStatus[,]>(_field_1);	}
			set { _field_1 = JsonConvert.SerializeObject(value); }
		}

		[NotMapped]
		public CellStatus[,] field_2 {
			get { return _field_2 == null ? null : JsonConvert.DeserializeObject<CellStatus[,]>(_field_2); }
			set { _field_2 = JsonConvert.SerializeObject(value); }
		}
	}
}
