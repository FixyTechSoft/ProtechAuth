using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Auth.Application.Validators.Conditions
{
    public static class ValidatorConditions
    {
        public static bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var numeric = new Regex("[0-9]+");
            var symbol = new Regex("[$%&!#]+");

            return (
                numeric.IsMatch(pw) && 
                lowercase.IsMatch(pw) && 
                uppercase.IsMatch(pw) && 
                symbol.IsMatch(pw)
                );
        }
    }
}
