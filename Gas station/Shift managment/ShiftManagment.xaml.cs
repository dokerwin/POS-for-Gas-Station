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

namespace Gas_station.Shift_managment
{
    /// <summary>
    /// Interaction logic for ShiftManagment.xaml
    /// </summary>
    ///
    public partial class ShiftManagment : Page
    {
        public List<Shifts> shiftList { set; get; }
 
        private MainWindow MainWindow;


       
        private void initShiftList() {

            shiftList = new List<Shifts>();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var ss = db.Shifts.ToList();
                foreach (var data in ss)
                {
                    shiftList.Add(new Shifts()
                    {
                        ShiftNumber = data.ShiftID,
                        Station = data.Station.Station_Name,
                        Cashier = data.Cashier.Person.Person_Name,
                        ShiftStart = data.ShiftStart,
                        ShiftEnd = data.ShiftEnd
                    }); ; 
                }
            }
        }

        private void UpdateShiftList()
        {
            shiftList.Clear();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var ss = db.Shifts.ToList();
                foreach (var data in ss)
                {
                    shiftList.Add(new Shifts()
                    {
                        ShiftNumber = data.ShiftID,
 
                        Station = data.Station.Station_Name,
                        ShiftStart = data.ShiftStart,
                        ShiftEnd = data.ShiftEnd
                    });
                }
            }


        }

          public ShiftManagment(MainWindow mainWindow)
        {
            MainWindow = mainWindow;
            initShiftList();
            InitializeComponent();
        }

        private void add_cashier_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void shift_off_btn_Click(object sender, RoutedEventArgs e)
        {

            ShiftHandler.EndShift();

            MainWindow.Main.Content = new Login.LoginPage(MainWindow);
            UpdateShiftList();
            shiftListView.Items.Refresh();

        }
        private void shift_pause_btn_Click(object sender, RoutedEventArgs e)
        {

         
         //   MainWindow.SetCashierStatus(ShiftStatus.Pause);
        }
    }
}
