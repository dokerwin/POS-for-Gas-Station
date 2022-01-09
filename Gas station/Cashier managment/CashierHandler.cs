using Gas_station.Shift_managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Cashier_managment
{
    class CashierHandler
    {

        private static Cashier actualCashier { get; set; }
        private static CashierHandler _instance;

        public static CashierHandler GetInstance()
        {
            if (_instance == null)
            {
                actualCashier = new Cashier();
               _instance = new CashierHandler();
            }
            return _instance;
        }



        public static Cashier GetActualCashier()
        {
            return actualCashier;
        }


        public static void setActualCashier(Cashier cashier)
        {
            actualCashier = cashier;
        }
    }



}
