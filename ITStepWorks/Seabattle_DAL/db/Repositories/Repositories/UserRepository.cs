using DB.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories
{
    public class UserRepository : DbRepository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }

	}
}
