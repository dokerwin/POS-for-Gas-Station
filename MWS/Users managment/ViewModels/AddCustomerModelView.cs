using MWS.Helper_Classes;
using MWS.Product_managment.MOP_managment;
using MWS.Users_managment.Loyalty_managment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
using MWS.MWSValidation;

namespace MWS.Users_managment.ViewModels
{
   public class AddCustomerModelView : ObservableObject, IPageViewModel, INotifyPropertyChanged, IObserver
    {
        private Observer _customerObserver;
        private bool edit = false;
        public List<MOP> MopList { get; set; } = MopHandler.GetListMOPs();
        public  MOP Mop { get; set; } = new MOP();

        public Customer _customer { get; set; } = new Customer()
        {
            LoyaltyCard = new LoyaltyCard()
            {
            },
            Person = new Person()
        };

        public AddCustomerModelView(Observer observer = null, Customer customer = null)
        {
            if(observer != null)
            {
                _customerObserver = observer;
                _customerObserver.Attach(this);
            }
            if(customer != null)
            {
                _customer = customer;
                edit = true;
            }
        }

        private ICommand _addCustomerButton;

        public List<String> SexList { get; set; } = new List<string> { "Male", "Feamle" };


        public ICommand AddCustomerButton
        {
            get
            {
                if (_addCustomerButton == null)
                {
                    _addCustomerButton = new RelayCommand(
                        param => SaveCustomer()
                    );
                }
                return _addCustomerButton;
            }
        }


        private void SaveCustomer()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (edit)
                {
                    try
                    {
                        db.Attach(_customer);
                        db.ObjectStateManager.ChangeObjectState(_customer, System.Data.EntityState.Modified);
                        db.SaveChanges();
                        MessageBox.Show("Customer data changed");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        


                        _customer.Register_date = DateTime.Now;
                        _customer.LoyaltyCard.ID_MOP = Mop.MopID;
                        db.People.AddObject(_customer.Person);
                        db.SaveChanges();
                        MessageBox.Show("Сustomer added");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check data");
                    }
                }
            }
            Mediator.Notify("AddCustomerView", null);

            _customerObserver.Notify();
        }


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Update(ISubject subject)
        {
            MopList = MopHandler.GetListMOPs();
        }

        #endregion INotifyPropertyChanged Members


        #region IPageViewModel interface

        public string Name
        {
            get { return "Add customer"; }
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
