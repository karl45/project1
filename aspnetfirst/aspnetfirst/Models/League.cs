using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class League
    {
        [Required(ErrorMessage = "Не указан Id")]
        public int LeagueId { set; get; }

        [Required(ErrorMessage = "Не указано название лиги")]
        public string LeaugueName { set; get; }

        
        public List<Team> Teams { set; get; }
    }
}
