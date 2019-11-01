using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class User
    {
        
        public int UserId { set; get; }
        public string Username { set; get; }
        public string UserPassword { set; get; }
        public int Points { set; get; }
        public List<UserMatch> UserMatches { set; get; }
    }
}
