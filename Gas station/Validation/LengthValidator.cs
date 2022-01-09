using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Gas_station.Validation
{
    public class LengthValidator : ValidationRule
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public override ValidationResult Validate(
          object value, System.Globalization.CultureInfo cultureInfo)
        {
        
            string text = String.Format("Must be between {0} and {1}",
                           MinValue, MaxValue);

            if (value.ToString().Length < MinValue)
                return new ValidationResult(false, "To small. " + text);
            if (value.ToString().Length > MaxValue)
                return new ValidationResult(false, "To large. " + text);
            return ValidationResult.ValidResult;
        }
    }
}