using PersonalInfoApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PersonalInfoApi.Data
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetails>()
                .HasKey(ud => ud.ID); // Configure the ID property as the primary key

            base.OnModelCreating(modelBuilder);
        }
    }
}
