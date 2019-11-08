using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Coach
    {
        [Required]
        public int CoachId { set; get; }
        [Required(ErrorMessage ="Не указано имя")]
        public string CoachName { set; get; }
        [Required]
        public int Rate { set; get; }
        public Team Team { set; get; }
    }
}
