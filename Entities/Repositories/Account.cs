using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public class Account : IAccount
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User GetByUsernameAndPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
