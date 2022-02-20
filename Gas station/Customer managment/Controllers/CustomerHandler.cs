using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Customer_managment
{
    public class CustomerHandler
    {

        public CustomerHandler()
        {

        }
  
        public static bool IsCustomerExist(int IdPerson)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return  db.Customers.Any(o => o.CustomerID == IdPerson);
            }
        }


        public static ObservableCollection<Customer> AllCustomers()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                ObservableCollection<Customer> observable =
                new ObservableCollection<Customer>();
                foreach (var a in db.Customers.Where(t => !String.IsNullOrEmpty(t.Person.Name)).ToList())
                {
                    if(!string.IsNullOrEmpty(a.Person.Name)
                        && !string.IsNullOrEmpty(a.Person.Adres_country))
                    observable.Add(a);
                }
                return observable;
            }
        }

    }
}
