using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface IScoreStatisticRepository
    {
        void Add(ScoreStatistic ScoreStatistic);
        Task Save();
        void Delete(ScoreStatistic ScoreStatistic);
        Task<List<ScoreStatistic>> GetAll();
        Task<List<ScoreStatistic>> GetPlayers(Expression<Func<ScoreStatistic, bool>> predicate);
        void Edit(ScoreStatistic ScoreStatistic);
        Task<ScoreStatistic> GetScoreStatistic(int id);
        bool ScoreStatisticExists(int id);
    }
}
