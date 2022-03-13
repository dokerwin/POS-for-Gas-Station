using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;

namespace MWS.Users_managment
{
    public class AllCustomersViewModel : ObservableObject, IPageViewModel
    {
        public ObservableCollection<Customer> customers { get; set; } = UserHandler.GetAllCustomers();
        public Customer customer { get; set; } = new Customer()
        {
            Person = new Person()
        };

        private ICommand findCustomerButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }
        private ICommand addCustomerButton { get; set; }

        #region IComand buttons
        public ICommand AddCustomerButton
        {
            get
            {
                return addCustomerButton ?? (addCustomerButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddCustomerView", null);
                }));
            }
        }

        public ICommand ButtonEdit
        {
            get
            {
                return buttonEdit;
            }
            set
            {
                buttonEdit = value;
            }
        }


        public ICommand FindCustomerButton
        {
            get
            {
                return findCustomerButton;
            }
            set
            {
                findCustomerButton = value;
            }
        }

        public ICommand ButtonDelete
        {
            get
            {
                return buttonDelete;
            }
            set
            {
                buttonDelete = value;
            }
        }
        #endregion

        #region Constructors
        public AllCustomersViewModel()
        {
            buttonDelete = new RelayCommand(DeleteCustomer);
            buttonEdit = new RelayCommand(EditCustomer);
            findCustomerButton = new RelayCommand(FindCustomer);
        }
        #endregion

        #region  Button's method
        private void EditCustomer(object customer)
        {
            Mediator.Notify("AddCutomerViewEdit", customer);
        }

        private void DeleteCustomer(object customer)
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

        private void FindCustomer(object cust)
        {
            customers.Clear();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var find = db.Customers.FirstOrDefault(i => i.Person.Name == customer.Person.Name);
                if (find != null)
                {
                    customers.Clear();
                    customers.Add(find);
                }
            }
        }
        #endregion

        #region IPageViewModel interface

        public string Name
        {
            get { return "All customers"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.CustomerManagemnet; }
        }
        #endregion
    }
}