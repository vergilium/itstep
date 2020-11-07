using DB.Entities;
using Microsoft.EntityFrameworkCore;


namespace DB.Repositories {
	public class RoomRepository : DbRepository<Room>, IRoomRepository {
		public RoomRepository(DbContext context) : base(context) {
		}
	}
}
