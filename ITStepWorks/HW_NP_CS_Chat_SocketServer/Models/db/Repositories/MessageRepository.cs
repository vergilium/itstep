using DB.Entities;
using DB.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DB.Repositories {
	class MessageRepository : DbRepository<Message>, IMessageRepository {
        public MessageRepository(DbContext context) : base(context) {
        }

    }
}
