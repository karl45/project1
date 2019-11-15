using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface ICoachRepository
    {
        void Add(Coach Coach);
        Task Save();
        void Delete(int id);
        Task<List<Coach>> GetAll();
        Task<List<Coach>> GetPlayers(Expression<Func<Coach, bool>> predicate);
        void Edit(Coach Coach);
        Task<Coach> GetCoach(int id);
        bool CoachExists(int id);
    }
}
