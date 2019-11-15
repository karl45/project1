using aspnetfirst.Data;
using aspnetfirst.Models;
using aspnetfirst.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Services
{
    public class ScoreStatisticServices
    {
        private readonly IScoreStatisticRepository _ScoreStatistics;
        public ScoreStatisticServices(IScoreStatisticRepository repository)
        {
            _ScoreStatistics = repository;
        }

        public async Task<List<ScoreStatistic>> GetScoreStatistics()
        {
            return await _ScoreStatistics.GetAll();
        }

        public async Task AddAndSave(ScoreStatistic ScoreStatistic)
        {
            _ScoreStatistics.Add(ScoreStatistic);
            await _ScoreStatistics.Save();
        }

        public async Task Edit(ScoreStatistic ScoreStatistic)
        {
            _ScoreStatistics.Edit(ScoreStatistic);
            await _ScoreStatistics.Save();
        }
        public async Task Delete(ScoreStatistic ScoreStatistic)
        {
            _ScoreStatistics.Delete(ScoreStatistic);
            await _ScoreStatistics.Save();
        }

        public async Task<List<ScoreStatistic>> Edit(int text)
        {
       
            var searchedScoreStatistices = await _ScoreStatistics.GetPlayers(ScoreStatistic => ScoreStatistic.ScoreStatisticId == text);
            return searchedScoreStatistices;
        }

        public bool ScoreStatisticExists(int id)
        {
            return _ScoreStatistics.ScoreStatisticExists(id);
        }
         public async Task<ScoreStatistic> GetScoreStatistic(int id)
        {
            return await _ScoreStatistics.GetScoreStatistic(id);
        }

    }
}
