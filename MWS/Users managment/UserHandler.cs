using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Users_managment
{
    public static class UserHandler
    {

        public static Customer GetNextCustomer()
        {
            Customer customer = new Customer();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                customer = db.Customers.Last();
            }

            return new Customer();
        }

        public static Customer GetNextEmployee()
        {


            return new Customer();
        }


        public static int GetNumberOfCustomers()
        {

            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Customers.Count();
            }

        }
    }
}
