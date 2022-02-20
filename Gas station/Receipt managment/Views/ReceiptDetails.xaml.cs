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

namespace Gas_station.Receipt_managment.Views
{
    /// <summary>
    /// Interaction logic for ReceiptDetails.xaml
    /// </summary>
    public partial class ReceiptDetails : UserControl
    {
        public ReceiptDetails()
        {
            InitializeComponent();
          
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }

        private void ChromiumWebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Address= "C:\\Projects\\Gas station\\Gas station\\bin\\Debug\\invoice.pdf";
        }
    }
}
