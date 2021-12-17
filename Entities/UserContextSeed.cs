using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserContextSeed
    {
        public static async Task SeedAsync(NALDbContext context)
        {
            await context.Users.AddAsync(new User { Id = 1, UserName = "admin", Password = "admin", UserType = UserType.Admin.ToString() });
            await context.SaveChangesAsync();
        }
    }
}
