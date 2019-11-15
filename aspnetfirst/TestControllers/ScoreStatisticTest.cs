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
    public class ScoreStatisticTest
    {
        [Fact]
        private async Task CreateTest()
        {
            var fakeRepository = Mock.Of<IScoreStatisticRepository>();
            var playerService = new ScoreStatisticServices(fakeRepository);
            var player = new ScoreStatistic() { ScoreStatisticId = 3};
            await playerService.AddAndSave(player);
        }
        [Fact]
        public async Task GetScoreStatisticsTest()
        {
            var movies = new List<ScoreStatistic>
            {
                new ScoreStatistic() { Numberofpenalty = 5 },
                new ScoreStatistic() { Numberofpenalty = 6 }
            };

            var fakeRepositoryMock = new Mock<IScoreStatisticRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(movies);


            var playerService = new ScoreStatisticServices(fakeRepositoryMock.Object);

            var resultScoreStatistics = await playerService.GetScoreStatistics();

            Assert.Collection(resultScoreStatistics, player =>
            {
                Assert.Equal(5, player.Numberofpenalty);
            },
            player =>
            {
                Assert.Equal(6, player.Numberofpenalty);
            });
        }
        [Fact]
        public async Task EditTest()
        {
            var fakeRepository = Mock.Of<IScoreStatisticRepository>();
            var playerService = new ScoreStatisticServices(fakeRepository);
            var player = new ScoreStatistic() { ScoreStatisticId = 3};
            await playerService.Edit(player);
        }
        [Fact]
        public async Task DeleteTest()
        {
            var fakeRepository = Mock.Of<IScoreStatisticRepository>();
            var playerService = new ScoreStatisticServices(fakeRepository);
            var player = new ScoreStatistic() { ScoreStatisticId = 2 };
            await playerService.Delete(player);
        }
        [Fact]
        public void ScoreStatisticExistsTest()
        {
            int ScoreStatisticId = 1;

            var fakeRepositoryMock = new Mock<IScoreStatisticRepository>();
            fakeRepositoryMock.Setup(x => x.ScoreStatisticExists(ScoreStatisticId)).Returns(true);

            var ScoreStatisticService = new ScoreStatisticServices(fakeRepositoryMock.Object);

            var isExist = ScoreStatisticService.ScoreStatisticExists(ScoreStatisticId);

            Assert.True(isExist);
        }
        [Fact]
        public async Task GetScoreStatisticTest()
        {
            int ScoreStatisticid = 1;
            var ScoreStatistic = new ScoreStatistic() { ScoreStatisticId = ScoreStatisticid };

            var fakeRepositoryMock = new Mock<IScoreStatisticRepository>();
            fakeRepositoryMock.Setup(x => x.GetScoreStatistic(ScoreStatisticid)).ReturnsAsync(ScoreStatistic);

            var ScoreStatisticService = new ScoreStatisticServices(fakeRepositoryMock.Object);

            var resultScoreStatistic = await ScoreStatisticService.GetScoreStatistic(ScoreStatisticid);

            Assert.Equal(ScoreStatisticid, resultScoreStatistic.ScoreStatisticId);
        }
    }
}
