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
                    Server = "127.0.0.1",
                    Database = "Seabattle",
                    UserID = "BattleShip",
                    Password = "Seabattle"
                }.ConnectionString)
                .Options);

            //_context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            UserRepository = new UserRepository(_context);
            
        }

        public static AppDbContext _context { get; }
        public static IUserRepository UserRepository { get; }
    }
}
