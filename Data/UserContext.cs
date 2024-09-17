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
                .HasKey(ud => ud.ID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
