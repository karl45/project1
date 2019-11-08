using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class User
    {
        [Required]
        public int UserId { set; get; }
        [UsernameValidate(ErrorMessage = "Введите количество символов больше 4")]
        public string Username { set; get; }
        [UsernameValidate(ErrorMessage = "Введите количество символов больше 4")]
        public string UserPassword { set; get; }
        [Required]
        public int Points { set; get; }
        public List<UserMatch> UserMatches { set; get; }
    }
}
