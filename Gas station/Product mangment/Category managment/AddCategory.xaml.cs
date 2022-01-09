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

namespace Gas_station.Product_mangment.Category_managment
{
    /// <summary>
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : UserControl
    {
        public Category category { get; set; }
        private MainWindow main;
        public AddCategory(MainWindow mainWindow)
        {
            main = mainWindow;
            category = new Category();
            InitializeComponent();
        }

        private void addCategory_btn_Click(object sender, RoutedEventArgs e)
        {
            using(Gas_stationDb db = new Gas_stationDb())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
            main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Category was\nadded successfuly", main));
        
    }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }
    }
}
