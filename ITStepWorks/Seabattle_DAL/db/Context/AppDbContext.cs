using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MySql.Data.EntityFrameworkCore.Extensions;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Context {
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Battle> Battles { get; set; }

        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent for User table
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);        

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

            #region Fluent for Room table
            modelBuilder.Entity<Room>()
                .Property(r => r.name)
                .IsRequired();

            modelBuilder.Entity<Room>()
                .Property(r => r.type_id)
                .HasDefaultValue(1)
                .IsRequired();

            modelBuilder.Entity<Room>()
                .HasMany(r => r.battles)
                .WithOne(b => b.room)
                .HasForeignKey(b => b.room_id);
            #endregion

            #region Fluent RoomPlayers table
            modelBuilder.Entity<RoomPlayers>()
                .HasKey(k => new { k.player_id, k.room_id });

            modelBuilder.Entity<RoomPlayers>()
                .HasOne(r => r.room)
                .WithMany(rp => rp.roomPlayers)
                .HasForeignKey(r => r.room_id);

            modelBuilder.Entity<RoomPlayers>()
                .HasOne(p => p.player)
                .WithMany(rp => rp.roomPlayer)
                .HasForeignKey(p => p.player_id);
            #endregion


            #region Fluent for Battle table
            modelBuilder.Entity<Battle>()
                .HasOne(b => b.room)
                .WithMany(r => r.battles)
                .HasForeignKey(b => b.room_id);
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
