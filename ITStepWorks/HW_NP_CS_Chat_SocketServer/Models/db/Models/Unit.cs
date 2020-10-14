using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DB.Context;
using DB.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models
{
    public static class Unit
    {
        static Unit()
        {
            _context = new AppDbContext(
                new DbContextOptionsBuilder<AppDbContext>()
                    .UseSqlServer(new SqlConnectionStringBuilder
                    {
                        DataSource = "127.0.0.1",
                        InitialCatalog = "Chat",
                        IntegratedSecurity = true
                    }.ConnectionString)
                    .Options);

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            UserRepository = new UserRepository(_context);
            MessageRepository = new MessageRepository(_context);
            
        }

        public static AppDbContext _context { get; }
        public static IUserRepository UserRepository { get; }
        public static IMessageRepository MessageRepository { get; }
    }
}
