using MWS;
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

namespace Gas_station.Product_mangment.Developer_managment
{
    /// <summary>
    /// Interaction logic for AddDeveloper.xaml
    /// </summary>
    public partial class AddDeveloper : UserControl
    {
        public Developer developer { get; set; }
        private MainWindow main;
        public AddDeveloper(MainWindow mainWindow)
        {
            main = mainWindow;
            developer = new Developer();
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }

        private void addDeveloper_btn_Click(object sender, RoutedEventArgs e)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                developer.ID_Company = db.Companies.First(a => a.Name == CompanyBox.SelectedValue.ToString()).CompanyID;
                db.Developers.Add(developer);
                db.SaveChanges();
            }
        //    main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Developer was\nadded successfuly", main));
        }
    }
}
