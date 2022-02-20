using System.Windows;
using Gas_station.Shift_managment;
using Gas_station.Login_managment;
using Gas_station.PrepareStation;
using Gas_station.Customer_managment.Views;
using Gas_station.LoyaltyCard_mamagment.Views;
using Gas_station.Forecourt_managment.Views;
using System;
using System.Windows.Navigation;
using System.Windows.Media.Animation;
using System.Windows.Controls;

namespace Gas_station
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        Pos.Pos posWindow;
        Gas_station.Login.LoginPage loginPage;
        ShiftManagment shiftManagmentPage;
        AddCustomer addCustomerPage;
        CardManagment _loyaltyCardManagment;


        private void initPages()
        {
            InitStation a = new InitStation();
            posWindow = new Pos.Pos(this);
            loginPage = new Login.LoginPage(this);

            addCustomerPage = new AddCustomer();
            shiftManagmentPage = new ShiftManagment(this);
            _loyaltyCardManagment = new CardManagment();

        }
        public MainWindow()
        {
            initPages();
            InitializeComponent();
            Main.Content = loginPage;
            Util.Util.setMainWindow(this);
        }


        private void PosWindowSelected(object sender, RoutedEventArgs e)
        {
            if (ShiftHandler.IsShiftOpen())
            {
                Main.Content = posWindow;
            }
            else
            {
                 Main.Content = loginPage;
            }
       
        }

        private void ShiftManagmentSelected(object sender, RoutedEventArgs e)
        {
            if (ShiftHandler.IsShiftOpen())
            {
                Main.Content = shiftManagmentPage;
            }
          
        }

        private void CustomerManagmentSelected(object sender, RoutedEventArgs e)
        {
            if (ShiftHandler.IsShiftOpen())
            {
                Main.Content = new Customer_managment.Views.Customers();
            }
        }

        private void CardManagmentSelected(object sender, RoutedEventArgs e)
        {
             if (ShiftHandler.IsShiftOpen())
            {
                Main.Content = _loyaltyCardManagment;
            }
        }

        private void FuelManagmentSelected(object sender, RoutedEventArgs e)
        {
            Main.Content = new ForecourtManagment();
        }

        private void MainFrame_OnNavigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            var ta = new ThicknessAnimation();
            ta.Duration = TimeSpan.FromSeconds(0.6);
            ta.DecelerationRatio = 0.7;
            ta.To = new Thickness(0, 0, 0, 0);
            if (e.NavigationMode == NavigationMode.New)
            {
                ta.From = new Thickness(500, 0, 0, 0);
            }
            else if (e.NavigationMode == NavigationMode.Back)
            {
                ta.From = new Thickness(0, 0, 500, 0);
            }
                 (e.Content as Page).BeginAnimation(MarginProperty, ta);
        }

        private void OredersManagmentSelected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Receipt_managment.Views.ReceiptManagment(this);
        }

        private void AddCustomerSelected(object sender, RoutedEventArgs e)
        {
            Main.Content = new Customer_managment.Views.AddCustomer();
        }

    }
    }
