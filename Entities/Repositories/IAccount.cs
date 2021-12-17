using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public interface IAccount
    {
        void Add(User user);
        User GetByUsernameAndPassword(string username, string password);
    }
}
