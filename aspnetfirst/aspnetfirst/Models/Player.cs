using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class Player:IValidatableObject
    {
        public Player() { 
        
        }
        public int PlayerId { set; get; }

      
        public string PlayerName { set; get; }

        public int Offence { set; get; }
        public int Deffence { set; get; }
        public int TeamId{ set; get; }

        public Team Team { set; get; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (PlayerId < 0)
                errors.Add(new ValidationResult("недопустимый Id"));
            if (Offence < 0)
                errors.Add(new ValidationResult("Введите корректный параметр атаки"));
            if (Deffence < 0)
                errors.Add(new ValidationResult("Введите корректный параметр защиты"));
            if (TeamId < 0)
                errors.Add(new ValidationResult("Введите команду"));
            return errors;
        }
    }
}
