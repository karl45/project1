using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetfirst.Models
{
    public class UsernameValidateAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is null)
                return false;
            if ((value as string).Length < 4)
                return false;
            return true;
        }
    }
}
