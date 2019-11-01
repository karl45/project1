using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class UserMatch
    {
        public int UserMatchId { set; get; }
        public int MatchId { set; get; }
        public Match Match { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
    }
}
