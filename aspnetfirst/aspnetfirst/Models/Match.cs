using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Match
    {
        
        public int MatchId { set; get; }
        public int Team_homeId { set; get; }
        public Team Team_home { set; get; }

        public int Team_guestId { set; get; }
        public Team Team_guest { set; get; }

        public ScoreStatistic ScoreStatistic { set; get; }
        public List<UserMatch> UserMatches { set; get; }
    }
}
