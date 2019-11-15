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
    public class CoachRepository : ICoachRepository
    {
        readonly BetContext _context;
        public CoachRepository(BetContext context)
        {
            _context = context;
        }
        public Task<Coach> GetCoach(int id)
        {
            return _context.Coach.FirstOrDefaultAsync(m => m.CoachId == id);
        }
        public void Add(Coach Coach)
        {
            _context.Add(Coach);
        }

        public void Delete(int id)
        {
            _context.Remove(_context.Coach.Find(id));
        }

        public void Edit(Coach Coach)
        { 
           _context.Update(Coach);  
        }

        public Task<List<Coach>> GetAll()
        {
            return _context.Coach.ToListAsync();
        }

        public Task<List<Coach>> GetPlayers(Expression<Func<Coach, bool>> predicate)
        {
            return _context.Coach.Where(predicate).ToListAsync();
        }


        public bool CoachExists(int id)
        {
            return _context.Coach.Any(e => e.CoachId == id);
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
