using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Gas_station.Validation
{
    public class PhoneValidator : ValidationRule
    {// Regular expression used to validate a phone number.  
        public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (IsPhoneNbr(value.ToString()))
                return new ValidationResult(false, "Phone is not correct");
            return ValidationResult.ValidResult;
        }
    }
}
