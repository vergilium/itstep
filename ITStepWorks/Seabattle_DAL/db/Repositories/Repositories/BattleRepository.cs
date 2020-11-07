using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories {
	public class BattleRepository : DbRepository<Battle>, IBattleRepository {
		public BattleRepository(DbContext context) : base(context) {
		}
	}
}
