using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gas_station.Customer_managment.Views
{
    /// <summary>
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : Page
    {
        public string _customer { get; set; } 
       public  ObservableCollection<Customer> customers { set; get; } = CustomerHandler.AllCustomers();
       
        public Customers()
        {
            InitializeComponent();
            
        }
 
        private void FindCustomer_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(_customer) && Util.Util.IsNumeric(_customer)) 
            {
                int a = Int32.Parse(_customer);
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    Customer a1 = db.Customers.FirstOrDefault(cus => cus.CustomerID == a);
                    if (a1 != null) 
                    {
                        customer_info_lbl.Content =
                         "Name: " + a1.Person.Name + "\n" +
                         "Surname: " + a1.Person.Surname + "\n" +
                         "Customer Id: " + a1.CustomerID + "\n" +
                         "Phone: " + a1.Person.Phone1 + "\n" +
                         "Country: " + a1.Person.Adres_country; 
                    }
                    else 
                    {
                        customer_info_lbl.Content = "Customer not exist \nor incorrect inputed data!";
                    }
                }
            }
        }

        private void customersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
