using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;
namespace Gas_station.Forecourt_managment
{
    public enum ForecourtStatus{
    Active = 1,
    Busy = 2
    }
    public static class DllHelper
    {
        private const string V = "ForecourtSimulator.dll";

        [System.Runtime.InteropServices.DllImport(V)]
        public static extern decimal simulateNozzle();
    }
    class ForecourtSettting
    {
        public ForecourtStatus status { get; set; }
       
        public static decimal SimulateNozzle()
        {
            try
            {
                return DllHelper.simulateNozzle();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

    }
}
