using Gas_station.Forecourt_managment.Controllers;
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

namespace Gas_station.Forecourt_managment.Views
{
    /// <summary>
    /// Interaction logic for ForecourtManagment.xaml
    /// </summary>
    public partial class ForecourtManagment: Page
    {
        public List<Cistern> _cisterns { set; get; }
  
        public ForecourtManagment()
        {
           
            InitializeComponent();
            initCisternList();
            initfuelDeliveryList();
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CisternList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void initCisternList()
        {
            CisternList.ItemsSource = ForecourtHandler.CisternList();
            CisternList.Items.Refresh();
        }
        private void initfuelDeliveryList()
        {
           FuelDeliveryList.ItemsSource = ForecourtHandler.FuelDeliveryList();
            FuelDeliveryList.Items.Refresh();
        }

    }
}
