using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class ScoreStatistic
    {
     
        public int ScoreStatisticId { set; get; }
        public string Score { set; get; }
        public int Numberofpenalty { set; get; }
        public int NumberofyellowCard { set; get; }
        public int Numberofredcard { set; get; }
        public int MatchId { set; get; }
        public Match Match { set; get; }
    }
}
