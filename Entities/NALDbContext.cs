using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class NALDbContext : DbContext
    {
        public NALDbContext(DbContextOptions<NALDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User { Id = 1, UserName="admin",Password="admin",UserType=UserType.Admin.ToString() });
        }
    }
}
