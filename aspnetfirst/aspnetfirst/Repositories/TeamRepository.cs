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
    public class TeamRepository : IteamRepository
    {
        readonly BetContext _context;
        public TeamRepository(BetContext context)
        {
            _context = context;
        }

        public void Add(Team team)
        {
            _context.Add(team);
        }

        public void Delete(Team player)
        {
            _context.Remove(player);
        }

        public void Edit(Team player)
        { 
           _context.Update(player);  
        }

        public Task<List<Team>> GetAll()
        {
            return _context.Team.ToListAsync();
        }

        public Task<List<Team>> GetPlayers(Expression<Func<Team, bool>> predicate)
        {
            return _context.Team.Where(predicate).ToListAsync();
        }

        public Task<Team> GetTeam(int id)
        {
            return _context.Team.FirstOrDefaultAsync(m => m.TeamId == id);
        }

        public bool TeamExists(int id)
        {
            return _context.Team.Any(e => e.TeamId == id);
        }


        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
