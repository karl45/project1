using aspnetfirst.Data;
using aspnetfirst.Models;
using aspnetfirst.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Services
{
    public class UserServices
    {
        private readonly IUserRepository _Users;
        public UserServices(IUserRepository repository)
        {
            _Users = repository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _Users.GetAll();
        }

        public bool UserExists(int id)
        {
            return _Users.UserExists(id);
        }
        public async Task<User> GetUser(int id)
        {
            return await _Users.GetUser(id);
        }
        public async Task AddAndSave(User User)
        {
            _Users.Add(User);
            await _Users.Save();
        }

        public async Task Edit(User User)
        {
            _Users.Edit(User);
            await _Users.Save();
        }
        public async Task Delete(User User)
        {
            _Users.Delete(User);
            await _Users.Save();
        }


        public async Task<List<User>> Edit(int text)
        {
            var searchedMovies = await _Users.GetPlayers(User => User.UserId == text);
            return searchedMovies;
        }

    }
}
