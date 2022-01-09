using Gas_station.Cashier_managment;
using Gas_station.Login;
using Gas_station.Shift_managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.PrepareStation
{
    class InitStation
    {
        private LoginManagment log_managment;
        private ShiftHandler shiftHandler;
        private CashierHandler cashierHandler;


        public InitStation()
        {
            log_managment = LoginManagment.GetInstance();
            shiftHandler = ShiftHandler.GetInstance();
            cashierHandler = CashierHandler.GetInstance();
        }
    }
}
