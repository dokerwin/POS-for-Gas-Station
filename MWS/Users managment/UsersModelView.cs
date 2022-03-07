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

namespace MWS.Users_managment
{
   public class UsersModelView : ObservableObject, IPageViewModel, INotifyPropertyChanged
    {


        public List<MOP> MopList { get; set; } = MopHandler.GetListMOPs();
        public  MOP Mop { get; set; } = new MOP();

        public Customer _customer { get; set; } = new Customer()
        {
            LoyaltyCard = new LoyaltyCard()
            {
                MOP = new MOP()
            },
            Person = new Person()
        };

        public UsersModelView(object obj = null)
        {
            if(obj != null)
            {
                _customer = (Customer)obj;
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

            //Person person = new Person()
            //{
            //    Name = _customer.Person.Name,
            //    Surname = _customer.Person.Surname,
            //    IDCard = _customer.Person.IDCard,
            //    Sex = _customer.Person.Sex,
            //    Age = _customer.Person.Age,
            //    Phone1 = _customer.Person.Phone1,
            //    Phone2 = _customer.Person.Phone2,
            //    Email1 = _customer.Person.Email1,
            //    Email2 = _customer.Person.Email2,
            //    Adres_country = _customer.Person.Adres_country,
            //    Adress_city = _customer.Person.Adress_city,
            //    Adress_level = _customer.Person.Adress_level,
            //    Adress_build = _customer.Person.Adress_build,
            //    Adress_zip = _customer.Person.Adress_zip,
            //    Adress_street = _customer.Person.Adress_street,
            //    Tax = _customer.Person.Tax
            //};

            //_customer.LoyaltyCard = new LoyaltyCard() { }

            using (Gas_stationDb db = new Gas_stationDb())
            {
                _customer.Register_date = DateTime.Now;
                _customer.LoyaltyCard.ID_MOP = Mop.MopID;
                db.People.Add(_customer.Person);
                db.SaveChanges();
                db.Customers.Add(_customer);
                OnNotifyPropertyChanged("MyProperty");
                db.SaveChanges();
                MessageBox.Show("Сustomer added");
            }
            Mediator.Notify("UserView", null);

        }

        public string Name
        {
            get { return "Customers"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion INotifyPropertyChanged Members



    }
}
