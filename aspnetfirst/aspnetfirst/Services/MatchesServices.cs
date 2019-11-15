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
    public class MatchServices
    {
        private readonly IMatchRepository _Matchs;
        public MatchServices(IMatchRepository repository)
        {
            _Matchs = repository;
        }

        public async Task<List<Match>> GetMatchs()
        {
            return await _Matchs.GetAll();
        }

        public async Task AddAndSave(Match Match)
        {
            _Matchs.Add(Match);
            await _Matchs.Save();
        }

        public bool MatchExists(int id)
        {
            return _Matchs.MatchExists(id);
        }
        public async Task<Match> GetMatch(int id)
        {
            return await _Matchs.GetMatch(id);
        }

        public async Task Edit(Match Match)
        {
            _Matchs.Edit(Match);
            await _Matchs.Save();
        }
        public async Task Delete(Match Match)
        {
            _Matchs.Delete(Match);
            await _Matchs.Save();
        }

        public async Task<List<Match>> Edit(int text)
        {
       
            var searchedmatches = await _Matchs.GetPlayers(Match => Match.MatchId == text);
            return searchedmatches;
        }

    }
}
