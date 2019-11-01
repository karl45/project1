using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Team
    {
        
        public int TeamId { set; get; }
        public string TeamName { set; get; }
        public int CoachId { set; get; }
        public Coach Coach { set; get; }
        public int TeamRate { set; get; }
        public List<Player> Players { set; get; }
        public int LeagueId { set; get; }
        public League League { set; get; }
        
    }
}
