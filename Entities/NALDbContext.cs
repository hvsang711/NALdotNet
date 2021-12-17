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

    }
}
