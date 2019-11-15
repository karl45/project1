using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface IPlayerRepository
    {
        void Add(Player player);
        Task Save();
        void Delete(Player player);
        Task<List<Player>> GetAll();
        Task<List<Player>> GetPlayers(Expression<Func<Player, bool>> predicate);
        void Edit(Player player);
        Task<Player> GetPlayer(int id);
        bool PlayerExists(int id);
    }
}
