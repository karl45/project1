using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface IteamRepository
    {
        void Add(Team team);
        Task Save();
        void Delete(Team team);
        Task<List<Team>> GetAll();
        Task<List<Team>> GetPlayers(Expression<Func<Team, bool>> predicate);
        void Edit(Team team);
        Task<Team> GetTeam(int id);
        bool TeamExists(int id);
    }
}
