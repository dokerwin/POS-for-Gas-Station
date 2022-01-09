using Gas_station.Product_mangment.Category_managment;
using Gas_station.Product_mangment.Developer_managment;
using Gas_station.Product_mangment.Distributor_managment;
using Gas_station.Product_mangment.Messure_managment;
using Gas_station.Product_mangment.Promotion_managment;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Gas_station.Product_management
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Page
    {
        public Product product { get; set; } = new Product();
        public List<Category> categories { get; set; } = new List<Category>();
        public List<Developer> developers { get; set; } = new List<Developer>();
        public List<Distributor> distributors { get; set; } = new List<Distributor>();
        public List<Promotion> promotions { get; set; } = new List<Promotion>();
        public List<Type_Product> messures { get; set; } = new List<Type_Product>();
        public Category category { get; set; } = new Category();
        public Developer developer { get; set; } = new Developer();
        public Distributor distributor { get; set; } = new Distributor();
        public Promotion promotion { get; set; } = new Promotion();
        public Type_Product messure { get; set; } = new Type_Product();

        public MainWindow mainWindow;
        private void RefreshItems()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                categories = db.Categories.ToList();

                developers = db.Developers.ToList();

                distributors = db.Distributors.ToList();

                promotions = db.Promotions.ToList();

                messures = db.Type_Product.ToList();
            }
        } 
        public AddProduct(MainWindow mainWindow , Product product)
        {
           
            this.mainWindow = mainWindow;
            this.product = product;
            RefreshItems();
            InitializeComponent();
            

        }
        public bool ValidateFields()
        {
            var controls = new[] { CategoryBox, DeveloperBox, DiscountBox, DistributorBox, MessureBox};

            bool isValid = true;
            foreach (var control in controls.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                isValid = false;
            }
            var textField = new[] { discription_txt, product_txt, price_txt };
            foreach (var control in textField.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                isValid = false;
            }

            return isValid;
        }


        private void AddProduct_btn(object sender, RoutedEventArgs e)
        { 
            if (ValidateFields())
            {
                if (product.ProductID != 0)
                {
                    using (Gas_stationDb db = new Gas_stationDb())
                    {
                        var result = db.Products.SingleOrDefault(b => b.ProductID == product.ProductID);
                        if (result != null)
                        {
                            result = product;
                            result.ID_Category = category.CategoryID;
                            result.ID_Developer = developer.DeveloperID;
                            result.ID_Distributor = distributor.DistributorID;
                            result.ID_Discount = promotion.PromotionID;
                            result.ID_Type_Product = messure.Type_ProductID;
                            result.Pro_LastUpdate = DateTime.Now;
                            db.SaveChanges();
                            mainWindow.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Product was \nupdate successfuly", mainWindow));
                            clearFields();
                        }
                    }
                   
                    return;
                }
               
                product.ID_Category = category.CategoryID;
                product.ID_Developer = developer.DeveloperID;
                product.ID_Distributor = distributor.DistributorID;
                product.ID_Discount = promotion.PromotionID;
                product.ID_Type_Product = messure.Type_ProductID;
                product.Pro_LastUpdate = DateTime.Now;

                using (Gas_stationDb db = new Gas_stationDb())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }

                mainWindow.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Product was \nadded successfuly", mainWindow));
                clearFields();
            }
        }

        private void Category_btn_Click(object sender, RoutedEventArgs e)
        {
            RefreshItems();
            mainWindow.pageTransitionControl.ShowPage(new AddCategory(mainWindow));

        }

        private void Messure_btn_Click(object sender, RoutedEventArgs e)
        {
           mainWindow.pageTransitionControl.ShowPage(new AddMessure(mainWindow));
        }

        private void Distributor_btn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.pageTransitionControl.ShowPage(new AddDistributor(mainWindow));
        }

        private void Developer_btn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.pageTransitionControl.ShowPage(new AddDeveloper(mainWindow));
        }

        private void Discount_btn_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.pageTransitionControl.ShowPage(new AddPromotion(mainWindow));
        }

        private void clearFields()
        {
            product = new Product();
        }

    }
}
