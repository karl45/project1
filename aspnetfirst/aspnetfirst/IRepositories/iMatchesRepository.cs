using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface IMatchRepository
    {
        void Add(Match Match);
        Task Save();
        void Delete(Match Match);
        Task<List<Match>> GetAll();
        Task<List<Match>> GetPlayers(Expression<Func<Match, bool>> predicate);
        void Edit(Match Match);
        Task<Match> GetMatch(int id);
        bool MatchExists(int id);
    }
}
