using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Users_managment
{
   public class UsersModelView : ObservableObject, IPageViewModel
    {
        private int _userId;
        private Customer _currentCustomer;
        private ICommand _getCustomerCommand;
        private ICommand _saveCustomerCommand;



        public int CustomerId
        {
            get { return _userId; }
            set
            {
                if (value != _userId)
                {
                    _userId = value;
                    OnPropertyChanged("CustomerId");
                }
            }
        }


        public Customer CurrentCustomer
        {
            get { return _currentCustomer; }
            set
            {
                if (value != _currentCustomer)
                {
                    _currentCustomer = value;
                    OnPropertyChanged("CurrentCustomer");
                }
            }
        }


        public ICommand GetProductCommand
        {
            get
            {
                if (_getCustomerCommand == null)
                {
                    _getCustomerCommand = new RelayCommand(
                        param => GetCustomer(),
                        param => CustomerId > 0
                    );
                }
                return _getCustomerCommand;
            }
        }

        public ICommand SaveProductCommand
        {
            get
            {
                if (_saveCustomerCommand == null)
                {
                    _saveCustomerCommand = new RelayCommand(
                        param => SaveCustomer(),
                        param => (CurrentCustomer != null)
                    );
                }
                return _saveCustomerCommand;
            }
        }


        private void GetCustomer()
        {
          
        }

        private void SaveCustomer()
        {
            // You would implement your Product save here
        }







        public string Name
        {
            get { return "Customers"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }
    }
}
