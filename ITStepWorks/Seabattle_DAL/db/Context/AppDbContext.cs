using DB.Entities;
using Microsoft.EntityFrameworkCore;

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
	}

}
