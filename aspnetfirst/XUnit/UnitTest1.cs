using aspnetfirst.Models;
using aspnetfirst.IRepositories;
using aspnetfirst.Services;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using aspnetfirst.Repositories;

namespace XUnit
{
    public static class UnitTest1
    {
        [Fact]
        private static async Task AddTest()
        {
            var fakeRepository = Mock.Of<IPlayerRepository>();
            var playerService = new PlayerServices(fakeRepository);
            var player = new Player() { PlayerId = 3, PlayerName = "RonaldoTest", Deffence = 48, Offence = 95, TeamId = 1 };
            await playerService.AddAndSave(player);
        }
    }
}
