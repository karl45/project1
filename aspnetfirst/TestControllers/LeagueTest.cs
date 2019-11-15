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
    public class LeagueTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<ILeagueRepository>();
            var playerService = new LeagueServices(fakeRepository);
            var player = new League() { LeagueId = 3};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetLeaguesTest()
        {
            var movies = new List<League>
            {
                new League() { LeagueId = 4 },
                new League() { LeagueId = 5 }
            };

            var fakeRepositoryMock = new Mock<ILeagueRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new LeagueServices(fakeRepositoryMock.Object);

            var resultLeagues = await playerService.GetLeagues();

            Assert.Collection(resultLeagues, player =>
            {
                Assert.Equal(4, player.LeagueId);
            },
            player =>
            {
                Assert.Equal(5, player.LeagueId);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<ILeagueRepository>();
            var playerService = new LeagueServices(fakeRepository);
            var player = new League() { LeagueId = 3};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<ILeagueRepository>();
            var playerService = new LeagueServices(fakeRepository);
            var player = new League() { LeagueId = 2 };
            await playerService.Delete(player);
        }
        [Fact]
        public async Task GetLeagueTest()
        {
            int Leagueid = 1;
            var League = new League() { LeagueId = Leagueid};

            var fakeRepositoryMock = new Mock<ILeagueRepository>();
            fakeRepositoryMock.Setup(x => x.GetLeague(Leagueid)).ReturnsAsync(League);

            var LeagueService = new LeagueServices(fakeRepositoryMock.Object);

            var resultLeague = await LeagueService.GetLeague(Leagueid);

            Assert.Equal(Leagueid, resultLeague.LeagueId);
        }
        [Fact]
        public void LeagueExistsTest()
        {
            int LeagueId = 1;

            var fakeRepositoryMock = new Mock<ILeagueRepository>();
            fakeRepositoryMock.Setup(x => x.LeagueExists(LeagueId)).Returns(true);

            var LeagueService = new LeagueServices(fakeRepositoryMock.Object);

            var isExist = LeagueService.LeagueExists(LeagueId);

            Assert.True(isExist);
        }


    }
}
