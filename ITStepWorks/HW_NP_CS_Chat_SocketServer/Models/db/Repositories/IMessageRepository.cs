using DB.Domain;
using DB.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Repositories {
	public interface IMessageRepository : IDbRepository<Message> {
	}
}
