using aspnetfirst.Models;
using aspnetfirst.IRepositories;
using aspnetfirst.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using aspnetfirst.Repositories;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace XUnit
{
    public class UnitTest1
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<IPlayerRepository>();
            var playerService = new PlayerServices(fakeRepository);
            var player = new Player() { PlayerId = 3, PlayerName = "RonaldoTest", Deffence = 48, Offence = 95, TeamId = 1 };
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetPlayersTest()
        {
            var movies = new List<Player>
            {
                new Player() { PlayerName = "test messi1" },
                new Player() { PlayerName = "test messi2" }
            };

            var fakeRepositoryMock = new Mock<IPlayerRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new PlayerServices(fakeRepositoryMock.Object);

            var resultPlayers = await playerService.GetPlayers();

            Assert.Collection(resultPlayers, player =>
            {
                Assert.Equal("test messi1", player.PlayerName);
            },
            player =>
            {
                Assert.Equal("test messi2", player.PlayerName);
            });
        }
        [Fact]
        public async Task EditTest() {
            var fakeRepository = Mock.Of<IPlayerRepository>();
            var playerService = new PlayerServices(fakeRepository);
            var player = new Player() { PlayerId = 3, PlayerName = "Ron", Deffence = 48, Offence = 95, TeamId = 1 };
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<IPlayerRepository>();
            var playerService = new PlayerServices(fakeRepository);
            var player = new Player() { PlayerId = 2};
            await playerService.Delete(player);
        }


        [Fact]
        public async Task GetPlayerTest()
        {
            int Playerid = 1;
            var Player = new Player() { PlayerId = Playerid };

            var fakeRepositoryMock = new Mock<IPlayerRepository>();
            fakeRepositoryMock.Setup(x => x.GetPlayer(Playerid)).ReturnsAsync(Player);

            var PlayerService = new PlayerServices(fakeRepositoryMock.Object);

            var resultPlayer = await PlayerService.GetPlayer(Playerid);

            Assert.Equal(Playerid, resultPlayer.PlayerId);
        }
        [Fact]
        public void PlayerExistsTest()
        {
            int PlayerId = 1;

            var fakeRepositoryMock = new Mock<IPlayerRepository>();
            fakeRepositoryMock.Setup(x => x.PlayerExists(PlayerId)).Returns(true);

            var PlayerService = new PlayerServices(fakeRepositoryMock.Object);

            var isExist = PlayerService.PlayerExists(PlayerId);

            Assert.True(isExist);
        }

    }
}
