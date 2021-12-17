using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository(NALDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public NALDbContext _dbContext { get; }

        public void RegisterUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            return _dbContext.Users.SingleOrDefault(u => u.UserName.ToLower() == username.ToLower() 
                            && u.Password.ToLower() == password.ToLower());
        }

        public bool IsUserExist(string username)
        {
            return _dbContext.Users.Any(us => us.UserName.ToLower() == username.ToLower());
        }
    }
}
