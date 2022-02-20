using Gas_station.Forecourt_managment.Controllers;
using Gas_station.Receipt_managment;
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
    /// Interaction logic for PrepayPomp.xaml
    /// </summary>
    public partial class PrepayPomp : UserControl
    {
        public Item fuel { get; set; }
        private Pos.Pos Pos;
        public int amount { get; set; }
        ReceiptHanler receiptHanler;
        public List<Product> fuelList { get; set; }

        private int forecourt { get; set; }
        
        public PrepayPomp(Pos.Pos pos, int forecout, ReceiptHanler a)
        {
            receiptHanler = a;
            fuel = new Item();
            fuelList = ForecourtHandler.FuelList();
            InitializeComponent();
            forecourt_txt.Content = "Forecourt: " + forecout.ToString();
            Pos = pos;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }

        private void Prepay_Click(object sender, RoutedEventArgs e)
        {
            if (fuel.product is null) 
            {
                return;
            }
            receiptHanler.AddProduct(fuel);
            Pos.updateReceiptList();
            ForecourtHandler.Prepay(forecourt, amount, fuel.product);
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;

        }
    }
}
