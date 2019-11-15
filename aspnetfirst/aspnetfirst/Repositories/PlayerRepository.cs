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
    public class PlayerRepository : IPlayerRepository
    {
        readonly BetContext _context;
        public PlayerRepository(BetContext context)
        {
            _context = context;
        }

        public void Add(Player player)
        {
            _context.Add(player);
        }

        public void Delete(Player player)
        {
            _context.Remove(player);
        }

        public void Edit(Player player)
        { 
           _context.Update(player);  
        }

        public Task<List<Player>> GetAll()
        {
            return _context.Player.ToListAsync();
        }

   
        public Task<List<Player>> GetPlayers(Expression<Func<Player, bool>> predicate)
        {
            return _context.Player.Where(predicate).ToListAsync();
        }

        public Task<Player> GetPlayer(int id)
        {
            return _context.Player.FirstOrDefaultAsync(m => m.PlayerId == id);
        }

        public bool PlayerExists(int id)
        {
            return _context.Player.Any(e => e.PlayerId == id);
        }
        public Task Save()
        {
            return _context.SaveChangesAsync();
        }
    }
}
