using aspnetfirst.IRepositories;
using aspnetfirst.Models;
using aspnetfirst.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestControllers
{
    public class UserTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<IUserRepository>();
            var playerService = new UserServices(fakeRepository);
            var player = new User() { UserId = 3};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetUsersTest()
        {
            var movies = new List<User>
            {
                new User() { UserId = 4 },
                new User() { UserId = 5 }
            };

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new UserServices(fakeRepositoryMock.Object);

            var resultUsers = await playerService.GetUsers();

            Assert.Collection(resultUsers, player =>
            {
                Assert.Equal(4, player.UserId);
            },
            player =>
            {
                Assert.Equal(5, player.UserId);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<IUserRepository>();
            var playerService = new UserServices(fakeRepository);
            var player = new User() { UserId = 3};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<IUserRepository>();
            var playerService = new UserServices(fakeRepository);
            var player = new User() { UserId = 2 };
            await playerService.Delete(player);
        }

        [Fact]
        public async Task GetUserTest()
        {
            int Userid = 1;
            var User = new User() { UserId = Userid };

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.GetUser(Userid)).ReturnsAsync(User);

            var UserService = new UserServices(fakeRepositoryMock.Object);

            var resultUser = await UserService.GetUser(Userid);

            Assert.Equal(Userid, resultUser.UserId);
        }
        [Fact]
        public void UserExistsTest()
        {
            int UserId = 1;

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.UserExists(UserId)).Returns(true);

            var UserService = new UserServices(fakeRepositoryMock.Object);

            var isExist = UserService.UserExists(UserId);

            Assert.True(isExist);
        }
    }
}
