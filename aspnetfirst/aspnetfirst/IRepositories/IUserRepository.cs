using aspnetfirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace aspnetfirst.IRepositories
{
    public interface IUserRepository
    {
        void Add(User User);
        Task Save();
        void Delete(User User);
        Task<List<User>> GetAll();
        Task<List<User>> GetPlayers(Expression<Func<User, bool>> predicate);
        void Edit(User User);
        Task<User> GetUser(int id);
        bool UserExists(int id);
    }
}
