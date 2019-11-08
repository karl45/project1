using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Team
    {

        [Required]
        public int TeamId { set; get; }

        [Remote(action: "VerifyName", controller: "Players", ErrorMessage = "Введите корректное имя")]
        public string TeamName { set; get; }
        [Required]
        public int CoachId { set; get; }

        public Coach Coach { set; get; }

        [Remote(action:"VerifyTeamRate", controller:"Teams",ErrorMessage ="Введите корректный рейтинг")]
        public int TeamRate { set; get; }

        public List<Player> Players { set; get; }
        [Required]
        public int LeagueId { set; get; }
        public League League { set; get; }
        
    }
}
