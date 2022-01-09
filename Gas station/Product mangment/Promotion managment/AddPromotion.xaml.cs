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

namespace Gas_station.Product_mangment.Promotion_managment
{
    /// <summary>
    /// Interaction logic for AddPromotion.xaml
    /// </summary>
    public partial class AddPromotion : UserControl
    {
        private MainWindow main;
        public Promotion promotion { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public AddPromotion(MainWindow mainWindow)
        {
            main = mainWindow;
            promotion = new Promotion();
            InitializeComponent();
        }

        private void addPromotion_btn_Click(object sender, RoutedEventArgs e)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                promotion.Prom_Start = Start.Value;
                promotion.Prom_End = End.Value;
                db.Promotions.Add(promotion);
                db.SaveChanges();
            }
            main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Promotion was\nadded successfuly", main));
        
    }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }
    }
}
