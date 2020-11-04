using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DB.Context {
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent for User table
            modelBuilder.Entity<User>()
                .HasIndex(u => u.login)
                .IsUnique(true);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.mail)
                .IsUnique(true);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.token)
                .IsUnique(true);
            #endregion


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseLoggerFactory(AppLoggerFactory);
        }
        // устанавливаем фабрику логгера
        public static readonly ILoggerFactory AppLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();    // указываем наш провайдер логгирования
        });
    }

}
