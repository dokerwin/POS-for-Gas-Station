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

namespace Gas_station.Product_mangment.Messure_managment
{
    /// <summary>
    /// Interaction logic for AddMessure.xaml
    /// </summary>
    public partial class AddMessure : UserControl
    {

        public Type_Product messure { get; set; }
        private MainWindow main;
        public AddMessure(MainWindow mainWindow)
        {
            main = mainWindow;
            messure = new Type_Product();
            InitializeComponent();
        }

        private void addMessure_btn_Click(object sender, RoutedEventArgs e)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Type_Product.Add(messure);
                db.SaveChanges();
            }
         // main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Unit was\nadded successfuly", main));
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }
    }
}
