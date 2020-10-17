using DB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace DB.Context {
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
      
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			#region Fluent for User table
			modelBuilder.Entity<User>()
                .HasMany(u => u.messages)
                .WithOne(m => m.sender)
                .HasPrincipalKey(u => u.Id)
                .HasForeignKey(m => m.sender_id);
			#endregion

			#region Fluent for Messages table
			modelBuilder.Entity<Message>()
                .HasOne(m => m.sender)
                .WithMany(u => u.messages)
                .HasPrincipalKey(u => u.Id)
                .HasForeignKey(m => m.sender_id);
			#endregion

		}
	}

}
