using Entities;
using Entities.Entities;
using Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;
using Xunit;

namespace UserTest
{
    public class AccountRepositoryTest : DbContextTest
    {
        public AccountRepositoryTest() : base(new DbContextOptionsBuilder<NALDbContext>()
                       .UseInMemoryDatabase(databaseName: "NALDatabase")
                       .Options)
        {

        }

        [Fact]
        public void GetUserByName_Password()
        {
            using (var context = new NALDbContext(ContextOptions))
            {
                // Arrange
                var userExpected = new User { Id = 1, UserName = "admin", Password = "admin", UserType = "Admin" };
                var accountRepo = new AccountRepository(context);

                // Act
                var userExist = accountRepo.GetByUsernameAndPassword(userExpected.UserName, userExpected.Password);
                var userNull = accountRepo.GetByUsernameAndPassword("sa", "sa123");
                // Assert
                Assert.Null(userNull);
                Assert.Equal(JsonConvert.SerializeObject(userExpected), JsonConvert.SerializeObject(userExist));
            }
        }

        [Fact]
        public void IsUserExistTest()
        {
            using (var context = new NALDbContext(ContextOptions))
            {
                // Arrange
                var accountRepo = new AccountRepository(context);

                // Act
                var userExist = accountRepo.IsUserExist("admin");
                var userNotExist = accountRepo.IsUserExist("admin2");

                // Assert
                Assert.True(userExist);
                Assert.False(userNotExist);
            }
        }

        [Fact]
        public void CanRegisterUser()
        {
            using (var context = new NALDbContext(ContextOptions))
            {
                // Arrange
                var accountRepo = new AccountRepository(context);
                var newUser = new User { Id = 4, UserName = "user4", Password = "user4", UserType = "User" };

                // Act
                accountRepo.RegisterUser(newUser);

                var getNewUser = accountRepo.GetByUsernameAndPassword(newUser.UserName, newUser.Password);

                // Assert

                Assert.Equal(JsonConvert.SerializeObject(newUser), JsonConvert.SerializeObject(getNewUser));
            }
        }
    }
}
