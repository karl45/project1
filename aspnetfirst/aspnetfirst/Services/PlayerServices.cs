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
    public class PlayerServices
    {
        private readonly IPlayerRepository _players;
        public PlayerServices(IPlayerRepository repository)
        {
            _players = repository;
        }

        public async Task<List<Player>> GetPlayers()
        {
            return await _players.GetAll();
        }

        public async Task AddAndSave(Player player)
        {
            _players.Add(player);
            await _players.Save();
        }

        public async Task Edit(Player player)
        {
            _players.Edit(player);
            await _players.Save();
        }
        public async Task Delete(Player player)
        {
            _players.Delete(player);
            await _players.Save();
        }


        public async Task<List<Player>> Edit(string text)
        {
            text = text.ToLower();
            var searchedMovies = await _players.GetPlayers(player => player.PlayerName.ToLower().Contains(text));
            return searchedMovies;
        }
        public bool PlayerExists(int id)
        {
            return _players.PlayerExists(id);
        }
        public async Task<Player> GetPlayer(int id)
        {
            return await _players.GetPlayer(id);
        }
    }
}
