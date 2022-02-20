using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MWS.MWSValidation
{
    public class EmailValidation : ValidationRule
    {
        public static bool EmailIsValid(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expression))
            {
                if (Regex.Replace(email, expression, string.Empty).Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public override ValidationResult Validate(
          object value, System.Globalization.CultureInfo cultureInfo)
        {

            if (!EmailIsValid(value.ToString()))
                return new ValidationResult(false, "Not an email");

            return ValidationResult.ValidResult;
        }
    }
}
