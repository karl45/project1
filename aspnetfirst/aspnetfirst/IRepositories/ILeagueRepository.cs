using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface ILeagueRepository
    {
        void Add(League League);
        Task Save();
        void Delete(League League);
        Task<List<League>> GetAll();
        Task<List<League>> GetPlayers(Expression<Func<League, bool>> predicate);
        void Edit(League League);
        Task<League> GetLeague(int id);
        bool LeagueExists(int id);
    }
}
