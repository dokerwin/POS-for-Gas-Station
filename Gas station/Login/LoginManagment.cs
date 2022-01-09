using Gas_station.Cashier_managment;
using Gas_station.Shift_managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Login
{
    class LoginManagment
    {
        
        private static LoginManagment _instance;
        private LoginManagment(){}
        public static LoginManagment GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginManagment();
            }
            return _instance;
        }

        public static bool SignOn(string login, string password)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                Cashier cashier;
                cashier = db.Cashiers.FirstOrDefault(m => m.Cashier_login == login && m.Cashier_password == password);
                if(cashier != null)
                {
                    CashierHandler.setActualCashier(cashier); 
                    return true; 
                }
            }
            return false;
        }
        public static void SignOff()
        {
            ShiftHandler.EndShift();
        }
    }
}
