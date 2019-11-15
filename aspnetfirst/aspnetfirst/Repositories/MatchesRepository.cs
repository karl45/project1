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
    public class MatchRepository : IMatchRepository
    {
        readonly BetContext _context;
        public MatchRepository(BetContext context)
        {
            _context = context;
        }

        public void Add(Match Match)
        {
            _context.Add(Match);
        }

        public void Delete(Match Match)
        {
            _context.Remove(Match);
        }

        public void Edit(Match Match)
        { 
           _context.Update(Match);  
        }

        public Task<List<Match>> GetAll()
        {
            return _context.Match.ToListAsync();
        }

        public Task<Match> GetMatch(int id)
        {
            return _context.Match.FirstOrDefaultAsync(m => m.MatchId == id);
        }

        public Task<List<Match>> GetPlayers(Expression<Func<Match, bool>> predicate)
        {
            return _context.Match.Where(predicate).ToListAsync();
        }

        public bool MatchExists(int id)
        {
            return _context.Match.Any(e => e.MatchId == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
