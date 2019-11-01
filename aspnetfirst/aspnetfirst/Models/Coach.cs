using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Coach
    {
        
        public int CoachId { set; get; }
        public string CoachName { set; get; }
        public int Rate { set; get; }
        public Team Team { set; get; }
    }
}
