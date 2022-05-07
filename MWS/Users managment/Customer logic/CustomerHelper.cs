using MWS.MWSValidation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TorasSQLHelper;

namespace MWS.Users_managment
{



    public static class CustomerHelper
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

        public static ObservableCollection<Customer> GetAllCustomers()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Customer> (db.Customers.Include("Person").Include("LoyaltyCard"));
            }
        }
       
        public static int GetNumberOfCustomers()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Customers.Count();
            }
        }

        private static bool CheckCustomerData(Customer customer)
        {
            bool success = false;
            if (customer.Person.Email2 == String.Empty)
            {
                customer.Person.Email2 = null;
            }
            else
            {
                if (!EmailValidation.EmailIsValid(customer.Person.Email2))
                {
                    MessageBox.Show("Сustomer Email2 is not correct");
                    success = false;
                }
            }
            if (customer.Person.Email1 == String.Empty)
            {
                MessageBox.Show("Сustomer Email1 cannot be empty");
            }
            if (!EmailValidation.EmailIsValid(customer.Person.Email1))
            {
                MessageBox.Show("Сustomer Email1 is not correct");
                success = false;
            }
            if (customer.Person.Phone1 == String.Empty)
            {
                MessageBox.Show("Сustomer Email1 is not correct");
            }
            if (customer.Person.Phone2 == String.Empty)
            {
                customer.Person.Phone2 = null;
            }

            return success;
        }


    }
}
