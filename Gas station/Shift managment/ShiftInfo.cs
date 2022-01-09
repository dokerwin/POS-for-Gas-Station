using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Shift_managment
{

    public enum ShiftStatus
    {

        SignOff,
        Active,
        Pause

    }

    public class Shifts
    {
        public int ShiftNumber { get; set; }
        public string Cashier { get; set; }
        public string Station { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }

    }


}
