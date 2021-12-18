using Entities;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserTest
{
    public class DbContextTest
    {
        protected DbContextTest(DbContextOptions<NALDbContext> contextOption)
        {
            ContextOptions = contextOption;
            Seed();
        }

        protected DbContextOptions<NALDbContext> ContextOptions { get; }

        private void Seed()
        {
            using (var context = new NALDbContext(ContextOptions))
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.AddRange(lstUser);
                context.SaveChanges();
            }
        }

        private List<User> lstUser
        {
            get
            {
                return new List<User>
                {
                     new User { Id=1 ,UserName = "admin", Password = "admin", UserType = "Admin" },
                     new User {Id=2 ,UserName = "user", Password = "user", UserType = "User" },
                     new User {Id=3 ,UserName = "user1", Password = "user1", UserType = "User" },
                };
            }
        }
    }
}
