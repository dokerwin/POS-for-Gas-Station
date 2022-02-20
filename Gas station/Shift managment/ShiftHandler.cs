using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Gas_station.Shift_managment
{
    class ShiftHandler
    {
        private static ShiftHandler _instance;
        private static Shift actualShift;
        private static bool isShiftOpen;
        private ShiftHandler(){}
        public static ShiftHandler GetInstance()
        {
            if (_instance == null)
            {
                actualShift = new Shift();
                _instance = new ShiftHandler();
            }
            return _instance;
        }

        public static void StartShift(Cashier cashier)
        {
            actualShift.Shift_start = DateTime.Now;
            actualShift.Shift_end = DateTime.Now;
            actualShift.ID_Cashier = cashier.CashierID;
            actualShift.ID_Station = 1;
            isShiftOpen = true;

            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Shifts.Add(actualShift);
                db.SaveChanges();
            }
        }

        public static void EndShift()
        {
            isShiftOpen = false;
            try
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                   var result= db.Shifts.SingleOrDefault(b => b.ShiftID == actualShift.ShiftID);

                    if (result != null)
                    {
                        result.Shift_end = DateTime.Now;
                        db.SaveChanges();
                        MessageBox.Show("Sign off", "Sign off is successfull", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        throw new ArgumentNullException("No such shift in DB");
                    }
                }  
            }
            catch (ArgumentNullException ar)
            {
              MessageBox.Show( ar.Message, "Sign off is aborted", MessageBoxButton.OK, MessageBoxImage.Information);
            }


        }

        public static bool IsShiftOpen()
        {
            return isShiftOpen;
        }


        public static Shift GetActualShift() {

            return actualShift;
        } 

    }
}
