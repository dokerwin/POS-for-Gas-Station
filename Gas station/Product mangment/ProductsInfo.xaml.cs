
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

namespace Gas_station.Product_mangment
{
    /// <summary>
    /// Interaction logic for ProductsInfo.xaml
    /// </summary>
    public partial class ProductsInfo : Page
    {
        MainWindow mainWindow;
        public ProductsInfo(MainWindow main)
        {
            mainWindow = main;
            InitializeComponent();
            DataContext = new ProductsModel();
        }




        //private void customersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var item = ((FrameworkElement)e.OriginalSource).DataContext as Product;
        //    if (item != null)
        //    {
        //        using (Gas_stationDb db = new Gas_stationDb())
        //        {
        //            Product product = db.Products.First(a => a.ProductID == item.ProductID);
        //            var ass = Product_mangment.ProductUtill.FindProduct(product.ProductID);
        //            if (ass != null)
        //            {
        //              mainWindow.Content = new AddProduct(mainWindow, product);
        //            }
        //        }
        //    }
        //}
    }
}
