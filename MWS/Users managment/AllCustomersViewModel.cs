using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Users_managment
{
    public class AllCustomersViewModel : ObservableObject, IPageViewModel
    {

        public List<Customer> customers { get; set; } = UserHandler.GetAllCustomers();

        public Customer SelectedCustomer { get; set; } = new Customer();


        //private ICommand _buttonEdit;

        public ICommand ButtonDelete { get; private set; }


        public AllCustomersViewModel()
        {
            ButtonDelete = new RelayCommand(Delete);
        }

        //public ICommand ButtonEdit
        //{
        //    get
        //    {
        //        if (_buttonEdit == null)
        //        {
        //            _buttonEdit = new RelayCommand(
        //                param => Edit()
        //            );
        //        }
        //        return _buttonEdit;
        //    }
        //}



        private void Delete(object customer)
        {
            var item = customer as Customer;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var customer1 = db.Customers.Include("Person").FirstOrDefault(i => i.CustomerID == item.CustomerID);
                    var person = db.People.FirstOrDefault(i => i.PersonID == item.ID_Person);
                    db.Customers.Remove(customer1);
                    db.People.Remove(person); 
                    db.SaveChanges();
                }
            }
        }

        public string Name
        {
            get { return "AllCustomers"; }
        }
        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

    }
}
