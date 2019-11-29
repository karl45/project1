using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class User:IdentityUser
    {
        public string UserPassword { set; get; }
        [Required]
        public int Points { set; get; }
        public List<UserMatch> UserMatches { set; get; }

    }
}
