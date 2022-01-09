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

namespace Gas_station.LoyaltyCard_mamagment.Views
{
    /// <summary>
    /// Interaction logic for CardManagment.xaml
    /// </summary>
    public partial class CardManagment : Page
    {
        private LoyaltyCardHandler loyaltyCardHandler;
        public int _cardNumber { get; set; }
        public int _amount { get; set; }

        public CardManagment()
        {
            loyaltyCardHandler = new LoyaltyCardHandler();
            InitializeComponent();
        }

        private void topUp_btn_Click(object sender, RoutedEventArgs e)
        {
          
            if (loyaltyCardHandler.findLoyalitycard(_cardNumber))
            {
                loyaltyCardHandler.TopUpCard(_amount);
                balance_lbl.Content = "Top up successful";
            }
            else
            {
                balance_lbl.Content = "Card not found";
            }
        }

        private void checkBalance_btn_Click(object sender, RoutedEventArgs e)
        {
            var amount = loyaltyCardHandler.getBalance(_cardNumber);
            if (amount != 0)
            {
                balance_lbl.Content = "Balance: " + amount;
            }
            else
            {
                balance_lbl.Content = "Card not found";
            }
        }

        private void addCustomer_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
