using aspnetfirst.Data;
using aspnetfirst.IRepositories;
using aspnetfirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.Repositories
{
    public class ScoreStatisticRepository : IScoreStatisticRepository
    {
        readonly BetContext _context;
        public ScoreStatisticRepository(BetContext context)
        {
            _context = context;
        }

        public void Add(ScoreStatistic ScoreStatistic)
        {
            _context.Add(ScoreStatistic);
        }

        public void Delete(ScoreStatistic ScoreStatistic)
        {
            _context.Remove(ScoreStatistic);
        }

        public void Edit(ScoreStatistic ScoreStatistic)
        { 
           _context.Update(ScoreStatistic);  
        }

        public Task<List<ScoreStatistic>> GetAll()
        {
            return _context.ScoreStatistic.ToListAsync();
        }

        public Task<List<ScoreStatistic>> GetPlayers(Expression<Func<ScoreStatistic, bool>> predicate)
        {
            return _context.ScoreStatistic.Where(predicate).ToListAsync();
        }

        public Task<ScoreStatistic> GetScoreStatistic(int id)
        {
            return _context.ScoreStatistic.FirstOrDefaultAsync(m => m.ScoreStatisticId == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public bool ScoreStatisticExists(int id)
        {
            return _context.ScoreStatistic.Any(m => m.ScoreStatisticId == id);
        }
    }
}
