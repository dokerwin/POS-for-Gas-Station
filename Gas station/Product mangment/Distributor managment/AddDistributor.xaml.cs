using System;
using System.Collections.Generic;
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

namespace Gas_station.Product_mangment.Distributor_managment
{
    /// <summary>
    /// Interaction logic for AddDistributor.xaml
    /// </summary>
    public partial class AddDistributor : UserControl
    {
        public Distributor distributor { get; set; }
        private MainWindow main;
        public AddDistributor(MainWindow mainWindow)
        {
            main = mainWindow;
            distributor = new Distributor();
            InitializeComponent();
        }

        private void addDistributor_btn_Click(object sender, RoutedEventArgs e)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                distributor.ID_Company = db.Companies.First(a => a.Company_Name == CompanyBox.SelectedValue.ToString()).CompanyID;
                db.Distributors.Add(distributor);
                db.SaveChanges();
            }
            main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Distributor was\nadded successfuly", main));
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }
    }
}
