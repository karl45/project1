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
    public class TeamTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<IteamRepository>();
            var playerService = new TeamServices(fakeRepository);
            var player = new Team() { TeamId = 3, TeamName = "RealTest"};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetTeamsTest()
        {
            var movies = new List<Team>
            {
                new Team() { TeamName = "test messi1" },
                new Team() { TeamName = "test messi2" }
            };

            var fakeRepositoryMock = new Mock<IteamRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new TeamServices(fakeRepositoryMock.Object);

            var resultTeams = await playerService.GetPlayers();

            Assert.Collection(resultTeams, player =>
            {
                Assert.Equal("test messi1", player.TeamName);
            },
            player =>
            {
                Assert.Equal("test messi2", player.TeamName);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<IteamRepository>();
            var playerService = new TeamServices(fakeRepository);
            var player = new Team() { TeamId = 3, TeamName = "Ron"};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<IteamRepository>();
            var playerService = new TeamServices(fakeRepository);
            var player = new Team() { TeamId = 2 };
            await playerService.Delete(player);
        }

        [Fact]
        public async Task GetTeamTest()
        {
            int Teamid = 1;
            var Team = new Team() { TeamId = Teamid };

            var fakeRepositoryMock = new Mock<IteamRepository>();
            fakeRepositoryMock.Setup(x => x.GetTeam(Teamid)).ReturnsAsync(Team);

            var TeamService = new TeamServices(fakeRepositoryMock.Object);

            var resultTeam = await TeamService.GetTeam(Teamid);

            Assert.Equal(Teamid, resultTeam.TeamId);
        }
        [Fact]
        public void TeamExistsTest()
        {
            int TeamId = 1;

            var fakeRepositoryMock = new Mock<IteamRepository>();
            fakeRepositoryMock.Setup(x => x.TeamExists(TeamId)).Returns(true);

            var TeamService = new TeamServices(fakeRepositoryMock.Object);

            var isExist = TeamService.TeamExists(TeamId);

            Assert.True(isExist);
        }
    }
}
