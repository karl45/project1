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
    public class TeamServices
    {
        private readonly IteamRepository _players;
        public TeamServices(IteamRepository repository)
        {
            _players = repository;
        }

        public async Task<List<Team>> GetPlayers()
        {
            return await _players.GetAll();
        }

        public async Task AddAndSave(Team player)
        {
            _players.Add(player);
            await _players.Save();
        }

        public async Task Edit(Team player)
        {
            _players.Edit(player);
            await _players.Save();
        }
        public async Task Delete(Team player)
        {
            _players.Delete(player);
            await _players.Save();
        }


        public async Task<List<Team>> Edit(string text)
        {
            text = text.ToLower();
            var searchedMovies = await _players.GetPlayers(player => player.TeamName.ToLower().Contains(text));
            return searchedMovies;
        }
        public bool TeamExists(int id)
        {
            return _players.TeamExists(id);
        }
        public async Task<Team> GetTeam(int id)
        {
            return await _players.GetTeam(id);
        }
    }
}
