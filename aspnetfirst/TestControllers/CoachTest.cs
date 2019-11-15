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
    public class CoachTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<ICoachRepository>();
            var playerService = new CoachServices(fakeRepository);
            var player = new Coach() { CoachId = 3, CoachName = "RealTest"};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetCoachsTest()
        {
            var movies = new List<Coach>
            {
                new Coach() { CoachName = "test messi1" },
                new Coach() { CoachName = "test messi2" }
            };

            var fakeRepositoryMock = new Mock<ICoachRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new CoachServices(fakeRepositoryMock.Object);

            var resultCoachs = await playerService.GetCoachs();

            Assert.Collection(resultCoachs, player =>
            {
                Assert.Equal("test messi1", player.CoachName);
            },
            player =>
            {
                Assert.Equal("test messi2", player.CoachName);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<ICoachRepository>();
            var playerService = new CoachServices(fakeRepository);
            var player = new Coach() { CoachId = 3, CoachName = "Ron"};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            int CoachId = 2;
            var fakeRepository = Mock.Of<ICoachRepository>();
            var playerService = new CoachServices(fakeRepository);
            await playerService.Delete(CoachId);
        }
        [Fact]
        public void CoachExistsTest()
        {
            int CoachId = 1;

            var fakeRepositoryMock = new Mock<ICoachRepository>();
            fakeRepositoryMock.Setup(x => x.CoachExists(CoachId)).Returns(true);

            var CoachService = new CoachServices(fakeRepositoryMock.Object);

            var isExist = CoachService.CoachExists(CoachId);

            Assert.True(isExist);
        }
        [Fact]
        public async Task GetCoachTest()
        {
            int coachid = 1;
            var Coach = new Coach() { CoachId = coachid, CoachName = "Coach One" };

            var fakeRepositoryMock = new Mock<ICoachRepository>();
            fakeRepositoryMock.Setup(x => x.GetCoach(coachid)).ReturnsAsync(Coach);

            var CoachService = new CoachServices(fakeRepositoryMock.Object);

            var resultCoach = await CoachService.GetCoach(coachid);

            Assert.Equal("Coach One", resultCoach.CoachName);
        }


    }
}
