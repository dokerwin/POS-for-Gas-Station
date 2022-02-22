using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MWS.Users_managment
{
   public class UsersModelView : ObservableObject, IPageViewModel
    {
       
        public Customer _customer { get; set; }  = new Customer() { Person = new Person() };
     
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
                db.Customers.Add(_customer);
                db.SaveChanges();
                MessageBox.Show("Product added");
                _customer = new Customer();
            }
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
