using aspnetfirst.IRepositories;
using aspnetfirst.Models;
using aspnetfirst.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Match = aspnetfirst.Models.Match;

namespace TestControllers
{
    public class MatchTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<IMatchRepository>();
            var playerService = new MatchServices(fakeRepository);
            var player = new aspnetfirst.Models.Match() { MatchId = 3};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetMatchsTest()
        {
            var movies = new List<aspnetfirst.Models.Match>
            {
                new Match() { MatchId = 4},
                new Match() { MatchId = 5}
            };

            var fakeRepositoryMock = new Mock<IMatchRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new MatchServices(fakeRepositoryMock.Object);

            var resultMatchs = await playerService.GetMatchs();

            Assert.Collection(resultMatchs, player =>
            {
                Assert.Equal(4, player.MatchId);
            },
            player =>
            {
                Assert.Equal(5, player.MatchId);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<IMatchRepository>();
            var playerService = new MatchServices(fakeRepository);
            var player = new Match() { MatchId = 3};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<IMatchRepository>();
            var playerService = new MatchServices(fakeRepository);
            var player = new Match() { MatchId = 2 };
            await playerService.Delete(player);
        }
        [Fact]
        public async Task GetMatchTest()
        {
            int Matchid = 1;
            var Match = new Match() { MatchId = Matchid };

            var fakeRepositoryMock = new Mock<IMatchRepository>();
            fakeRepositoryMock.Setup(x => x.GetMatch(Matchid)).ReturnsAsync(Match);

            var MatchService = new MatchServices(fakeRepositoryMock.Object);

            var resultMatch = await MatchService.GetMatch(Matchid);

            Assert.Equal(Matchid, resultMatch.MatchId);
        }
        [Fact]
        public void MatchExistsTest()
        {
            int MatchId = 1;

            var fakeRepositoryMock = new Mock<IMatchRepository>();
            fakeRepositoryMock.Setup(x => x.MatchExists(MatchId)).Returns(true);

            var MatchService = new MatchServices(fakeRepositoryMock.Object);

            var isExist = MatchService.MatchExists(MatchId);

            Assert.True(isExist);
        }

    }
}
