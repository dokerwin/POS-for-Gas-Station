using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Page
    {
        public Person person { get; set; }

        public AddCustomer()
        {
            person = new Person() {Location = new Location()};
            InitializeComponent();
            SexBox.Items.Add("Male");
            SexBox.Items.Add("Female");
        }
     
        private void AddCustomer_btn(object sender, RoutedEventArgs e)
        {

            using(Gas_stationDb db = new Gas_stationDb())
            { LoyaltyCard loyaltyCard = new LoyaltyCard() { ID_MOP = 2, Amount = 0 };
                

                db.Locations.Add(person.Location);
                db.SaveChanges();
                person.ID_Location = person.Location.LocationID;
                db.People.Add(person);
                db.SaveChanges();
                db.LoyaltyCards.Add(loyaltyCard);
                db.SaveChanges();
                db.Customers.Add(new Customer() { ID_Person = person.PersonID, ID_LoyaltyCard = loyaltyCard.LoyaltyCardID });
                db.SaveChanges();

            }

        }

        private void SexBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            person.Person_Sex = SexBox.SelectedItem.ToString();
        }
    }
}
