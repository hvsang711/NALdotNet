using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repositories
{
    public interface IAccountRepository
    {
        void RegisterUser(User user);
        User GetByUsernameAndPassword(string username, string password);
        bool IsUserExist(string username);
    }
}
