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
    public class UserRepository : IUserRepository
    {
        readonly BetContext _context;
        public UserRepository(BetContext context)
        {
            _context = context;
        }
        public bool UserExists(int id)
        {
            return _context.User.Any(e => Convert.ToInt32(e.Id) == id);
        }

        public void Add(User User)
        {
            _context.Add(User);
        }

        public void Delete(User User)
        {
            _context.Remove(User);
        }

        public void Edit(User User)
        { 
           _context.Update(User);  
        }

        public Task<List<User>> GetAll()
        {
            return _context.User.ToListAsync();
        }

        public Task<List<User>> GetPlayers(Expression<Func<User, bool>> predicate)
        {
            return _context.User.Where(predicate).ToListAsync();
        }

        public Task Save()
        {
            return _context.SaveChangesAsync();
        }

        public Task<User> GetUser(int id)
        {
            return _context.User.FirstOrDefaultAsync(m => Convert.ToInt32(m.Id) == id);
        }
    }
}
