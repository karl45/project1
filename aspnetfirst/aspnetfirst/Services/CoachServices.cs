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
    public class CoachServices
    {
        private readonly ICoachRepository _Coachs;
        public CoachServices(ICoachRepository repository)
        {
            _Coachs = repository;
        }

        public async Task<List<Coach>> GetCoachs()
        {
            return await _Coachs.GetAll();
        }

        public bool CoachExists(int id)
        {
            return _Coachs.CoachExists(id);
        }

        public async Task AddAndSave(Coach Coach)
        {
            _Coachs.Add(Coach);
            await _Coachs.Save();
        }

        public async Task Edit(Coach Coach)
        {
            _Coachs.Edit(Coach);
            await _Coachs.Save();
        }
        public async Task Delete(int id)
        {
            _Coachs.Delete(id);
            await _Coachs.Save();
        }
        public async Task<Coach> GetCoach(int id)
        {
            return await _Coachs.GetCoach(id);
        }

        public async Task<List<Coach>> Edit(string text)
        {
            text = text.ToLower();
            var searchedMovies = await _Coachs.GetPlayers(Coach => Coach.CoachName.ToLower().Contains(text));
            return searchedMovies;
        }

    }
}
