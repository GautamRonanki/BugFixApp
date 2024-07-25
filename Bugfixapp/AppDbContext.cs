using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugfixapp
{
    public class AppDbContext : DbContext
    {
        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbValue> Values { get; set; }
        public DbSet<DbUserValue> UserValues { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define composite key for DbUserValue
            modelBuilder.Entity<DbUserValue>()
                .HasKey(uv => new { uv.UserId, uv.ValueId });

            // Define relationships
            modelBuilder.Entity<DbUserValue>()
                .HasOne(uv => uv.User)
                .WithMany(u => u.UserValues)
                .HasForeignKey(uv => uv.UserId);

            modelBuilder.Entity<DbUserValue>()
                .HasOne(uv => uv.Value)
                .WithMany(v => v.UserValues)
                .HasForeignKey(uv => uv.ValueId);

            // Define primary keys for DbUser and DbValue
            modelBuilder.Entity<DbValue>().HasKey(v => v.ValueId);
            modelBuilder.Entity<DbUser>().HasKey(u => u.UserId);
        }
    }

    public class DbValue
    {
        public Guid ValueId { get; set; }
        public string Title { get; set; }
        public List<DbUserValue> UserValues { get; set; }
    }

    public class DbUser
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public List<DbUserValue> UserValues { get; set; }
    }

    public class DbUserValue
    {
        public Guid UserId { get; set; }
        public Guid ValueId { get; set; }
        public DbUser User { get; set; }
        public DbValue Value { get; set; }
    }
}
