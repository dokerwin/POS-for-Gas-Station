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

namespace Gas_station.MOPS
{
    /// <summary>
    /// Interaction logic for MOP_managment.xaml
    /// </summary>
    public partial class MOP_managment : UserControl
    {
        Pos.Pos _mainWindow;
        public int CustomerId { get; set; }
        public MOP_managment(Pos.Pos mainWindow)
        {
            InitializeComponent();
           _mainWindow = mainWindow;
        }


        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }

        private void Loyalty_card_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_mainWindow.isTotalPressed)
            {
                if (Customer_managment.CustomerHandler.IsCustomerExist(CustomerId))
                    _mainWindow.PayEnd();
                else customer_txt.Text = "Not found";
            }
        }
    }
}
