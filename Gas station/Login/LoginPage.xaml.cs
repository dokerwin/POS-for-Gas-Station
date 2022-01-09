using Gas_station.Cashier_managment;
using Gas_station.Shift_managment;
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

namespace Gas_station.Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        private MainWindow MainWindow;
  
        public LoginPage(MainWindow mainWindow)
        {
            InitializeComponent();
            MainWindow = mainWindow;
           
        }

       


        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
           
        }
    

        private void Login_btn_Click(object sender, RoutedEventArgs e)
        {
          
                if (LoginManagment.SignOn(login_txt.Text, passwordBox.Password))
                {
                MainWindow.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Successful\nYour shift started", MainWindow));
                ShiftHandler.StartShift(CashierHandler.GetActualCashier());
                  
                MainWindow.Main.Content = new Pos.Pos(MainWindow);
                 }
                else
                {
                    login_txt.BorderBrush = Brushes.Red;

                    passwordBox.BorderBrush = Brushes.Red;
                }

        }
        

        private void login_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            passwordBox.BorderBrush = Brushes.Black;
            login_txt.BorderBrush = Brushes.Black;
        }
    }
}
