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
    public class LeagueRepository : ILeagueRepository
    {
        readonly BetContext _context;
        public LeagueRepository(BetContext context)
        {
            _context = context;
        }
        public bool LeagueExists(int id)
        {
            return _context.League.Any(e => e.LeagueId == id);
        }

        public void Add(League League)
        {
            _context.Add(League);
        }

        public void Delete(League League)
        {
            _context.Remove(League);
        }

        public void Edit(League League)
        { 
           _context.Update(League);  
        }

        public Task<List<League>> GetAll()
        {
            return _context.League.ToListAsync();
        }

        public Task<List<League>> GetPlayers(Expression<Func<League, bool>> predicate)
        {
            return _context.League.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public Task<League> GetLeague(int id)
        {
            return _context.League.FirstOrDefaultAsync(m => m.LeagueId == id);
        }
    }
}
