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
    public class LeagueServices
    {
        private readonly ILeagueRepository _Leagues;
        public LeagueServices(ILeagueRepository repository)
        {
            _Leagues = repository;
        }

        public async Task<List<League>> GetLeagues()
        {
            return await _Leagues.GetAll();
        }

        public bool LeagueExists(int id)
        {
            return _Leagues.LeagueExists(id);
        }

        public async Task AddAndSave(League League)
        {
            _Leagues.Add(League);
            await _Leagues.Save();
        }

        public async Task Edit(League League)
        {
            _Leagues.Edit(League);
            await _Leagues.Save();
        }
        public async Task Delete(League League)
        {
            _Leagues.Delete(League);
            await _Leagues.Save();
        }
        public async Task<League> GetLeague(int id)
        {
            return await _Leagues.GetLeague(id);
        }
  

        public async Task<List<League>> Edit(int text)
        {
            
            var searchedMovies = await _Leagues.GetPlayers(League => League.LeagueId == text);
            return searchedMovies;
        }

    }
}
