using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Player
    {
        
        public int PlayerId { set; get; }
        public string PlayerName { set; get; }
        public int Offence { set; get; }
        public int Deffence { set; get; }
        public int TeamId{ set; get; }
        public Team Team { set; get; }

    }
}
