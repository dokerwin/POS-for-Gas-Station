using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Util.Pdf
{
    public class TotalRow
    {
        public string Text;
        public decimal Value;

        public TotalRow(string text, decimal value)
        {
            Text = text;
            Value = value;
        }
    }
}
