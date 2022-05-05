using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;

namespace MWS.Users_managment
{

    public enum SortType
    {
        ById,
        ByName
    }
    public enum FilterType 
    {
        All,
        Active,
        Fired
    }




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

        public static ObservableCollection<Customer> GetAllCustomers()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Customer> (db.Customers.Include("Person").Include("LoyaltyCard"));
            }
        }
        public static List<TypeOfEmployment> GetAllEmploymentTypes()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.TypeOfEmployments.ToList();
            }
        }
        public static int GetNumberOfCustomers()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Customers.Count();
            }
        }

        public static List<EmPosition> GetAllEmployeePostion()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.EmPositions.ToList();
            }
        }


        public static ObservableCollection<Cashier> GetAllEmployees(FilterType filter)
        {
            ObservableCollection<Cashier> tempEmployeeList = null;

            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (filter == FilterType.Active)
                {
                    tempEmployeeList = new ObservableCollection<Cashier>(db.Cashiers.Include("Person").Where(em => em.Fire_date == null));
                }

                if (filter == FilterType.Fired)
                {
                    tempEmployeeList = new ObservableCollection<Cashier>(db.Cashiers.Include("Person").Where(em => em.Fire_date != null));
                }

                if (filter == FilterType.All)
                {
                    tempEmployeeList = new ObservableCollection<Cashier>(db.Cashiers.Include("Person").ToList());
                }

                return tempEmployeeList;
            }
        }




        public static List<Staff> GetAllStaffType()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Staffs.ToList();
            }
        }
    }
}
