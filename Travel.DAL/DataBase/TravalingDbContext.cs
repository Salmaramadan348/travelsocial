using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Tracing;
using Travel.DAL.Entities.Models;

namespace Travel.DAL.DataBase
{
    public class TravalingDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UD5HDTJ;Database=Travaling;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupMembership>()
                .HasKey(gm => new { gm.UserId, gm.GroupId });

            modelBuilder.Entity<GroupMembership>()
                .HasOne(gm => gm.User)
                .WithMany(u => u.GroupMemberships)
                .HasForeignKey(gm => gm.UserId);

            modelBuilder.Entity<GroupMembership>()
                .HasOne(gm => gm.Group)
                .WithMany(g => g.GroupMemberships)
                .HasForeignKey(gm => gm.GroupId);
        }
       public DbSet<User> Users { get; set; }
       public DbSet<Group>Groups { get; set; }
       public DbSet<GroupMembership> GroupMemberships { get; set; }
       public DbSet<Event> Events { get; set; }

    }
}
