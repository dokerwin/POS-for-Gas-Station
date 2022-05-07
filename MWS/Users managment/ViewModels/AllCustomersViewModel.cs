using MWS.Helper_Classes;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;

namespace MWS.Users_managment.ViewModels
{
    public class AllCustomersViewModel : ObservableObject, IPageViewModel, IObserver
    {
        #region Constructors/Destructors
        public AllCustomersViewModel(object obj = null)
        {
            if(obj is Observer)
            {
                observer = obj as Observer;
                observer?.Attach(this);
            }
            
            buttonDelete = new RelayCommand(DeleteCustomer);
            buttonEdit = new RelayCommand(EditCustomer);
            findCustomerButton = new RelayCommand(FindCustomer);
            UpdateCustomerList();
        }
        #endregion

        #region Public members
        public ObservableCollection<Customer> customers
        {
            get 
            { 
                if (_customers is null)
                {
                    _customers = CustomerHelper.GetAllCustomers();
                } 
                return _customers;
            }
            set
            {
                _customers = value;
                RaisePropertyChanged("customers");
            }
        }
        public Customer customer { get; set; } = new Customer()
        {
            Person = new Person()
        };

        #endregion

        #region Public methods
        public void UpdateCustomerList(object sender, MyEventArgs e)
        {
            customers = CustomerHelper.GetAllCustomers();
        }

        public void UpdateCustomerList()
        {
            customers = CustomerHelper.GetAllCustomers();
        }

        public void Update(ISubject subject)
        {
            UpdateCustomerList();
        }

        #endregion

        #region IComand buttons
        private ICommand findCustomerButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }
        private ICommand addCustomerButton { get; set; }

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

        #region Private members 

        public ObservableCollection<Customer> _customers = null;
        private Observer observer;

        #endregion

        #region  Button private methods
        private void EditCustomer(object customer)
        {
            Mediator.Notify("AddCustomerViewEdit", customer);
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
                    db.Customers.DeleteObject(customer1);
                    db.People.DeleteObject(person);
                    db.SaveChanges();
                    UpdateCustomerList();
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