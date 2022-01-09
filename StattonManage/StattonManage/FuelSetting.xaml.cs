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

namespace StattonManage
{
    /// <summary>
    /// Interaction logic for FuelSetting.xaml
    /// </summary>
    public partial class FuelSetting : Page
    {

        public decimal price { get; set; }
        public List<Fuel> fuel { get; set; }

        void ListInit()
        {
            using (Gas_stationEntities db = new Gas_stationEntities())
            {
                foreach (var element in db.Products.Where(c => c.Category.Cat_Name == "Fuel").ToList())
                {
                    fuel.Add(new Fuel
                    {
                        FuelName = element.Pro_Name,
                        FuelPrice = element.Pro_Price,
                        TimeLastPrice = (DateTime)element.Pro_LastUpdate
                    });
                }
            }
        }


        void ListUpdate()
        {
            using (Gas_stationEntities db = new Gas_stationEntities())
            {
                foreach (var element in db.Products.Where(c => c.Category.Cat_Name == "Fuel").ToList())
                {
                    fuel.Find(x => x.FuelName  == element.Pro_Name).FuelPrice = element.Pro_Price;
                    fuel.Find(x => x.FuelName == element.Pro_Name).TimeLastPrice = (DateTime)element.Pro_LastUpdate;
                }
            }
        }



        public FuelSetting()
        {
            fuel = new List<Fuel>();

            InitializeComponent();
            ListInit();
            using (Gas_stationEntities db = new Gas_stationEntities())
            {
                FuelBox.ItemsSource = db.Products.Where(c => c.Category.Cat_Name == "Fuel").Select(c => c.Pro_Name).ToList();
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (fuelList.SelectedItems.Count > 0)
            {
                var item = fuelList.SelectedItems[0];
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (var db = new Gas_stationEntities())
            {

                var result = db.Products.SingleOrDefault(b => b.Pro_Name == FuelBox.Text);
                if (result != null)
                {

                    if (price  > (result.Pro_Price * 1.2m))
                    {

                        MessageBox.Show("Difference soo big\nPlease check the price\nor contact the support");
                    }
                    else
                    {
                        result.Pro_Price = price;
                        result.Pro_LastUpdate = DateTime.Now;
                        db.SaveChanges();
                        ListUpdate();
                        fuelList.Items.Refresh();
                    }
                }

            }
        }
    }

}