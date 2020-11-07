using Microsoft.EntityFrameworkCore;
using DB.Context;
using DB.Repositories;
using MySql.Data.MySqlClient;

namespace DB.Models
{
    public static class Unit
    {
        static Unit()
        {
            _context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>()
                .UseMySQL(new MySqlConnectionStringBuilder {
                    Server = "localhost",
                    Database = "Seabattle",
                    UserID = "root",
                    Password = "M@loivan123"
                }.ConnectionString)
                .Options);

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            UserRepository = new UserRepository(_context);
            RoomRepository = new RoomRepository(_context);
            BattleRepository = new BattleRepository(_context);
        }

        public static AppDbContext _context { get; }
        public static IUserRepository UserRepository { get; }
        public static IRoomRepository RoomRepository { get; }
        public static IBattleRepository BattleRepository { get; }
    }
}
