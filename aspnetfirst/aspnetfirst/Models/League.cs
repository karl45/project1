using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class League
    {
        public int LeagueId { set; get; }
        public string LeaugueName { set; get; }
        public List<Team> Teams { set; get; }
    }
}
