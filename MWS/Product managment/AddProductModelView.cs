using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;

namespace MWS.Product_managment
{
   
    public class AddProductModelView: ObservableObject, IPageViewModel,  INotifyPropertyChanged
    {
        #region Variable to bind 
        public Product product { get; set; } = new Product();
        public List<Category> categories { get; set; } = new List<Category>();
        public List<Developer> developers { get; set; } = new List<Developer>();
        public List<Distributor> distributors { get; set; } = new List<Distributor>();
        public List<ProdPromotion> promotions { get; set; } = new List<ProdPromotion>();
        public List<Type_Product> messures { get; set; } = new List<Type_Product>();
        public Category category { get; set; } = new Category();
        public Developer developer { get; set; } = new Developer();
        public Distributor distributor { get; set; } = new Distributor();
        public Type_Product messure { get; set; } = new Type_Product();
        #endregion

        private ICommand addProductButton { get; set; }
        private ICommand addCategoryButton { get; set; }
        private ICommand addMessureButton { get; set; }

        bool edit = false;

        public ICommand AddCategoryButton
        {
            get
            {
                return addCategoryButton ?? (addCategoryButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddCategoryView", null);
                }));
            }
        }
        public ICommand AddMessureButton
        {
            get
            {
                return addMessureButton;
            }
            set
            {
                addMessureButton = value;
            }
        }
        public ICommand AddProductButton
        {
            get
            {
                return addProductButton;
            }
            set
            {
                addProductButton = value;
            }
        }


        public AddProductModelView(object obj= null, bool edit = false) 
        {
            if(obj != null)
            {
                product = obj as Product;
                this.edit = edit;
            }

            addProductButton = new RelayCommand(AddProduct);
            RefreshItems();
        }

        private void RefreshItems()
        {
 
            using (Gas_stationDb db = new Gas_stationDb())
            {
                categories = db.Categories.ToList();

                developers = db.Developers.ToList();

                distributors = db.Distributors.ToList();

                promotions = db.ProdPromotions.ToList();

                messures = db.Type_Product.ToList();
            }
        }


        public void UpdateProduct(object obj)
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
                        //result.ID_Discount = promotion.PromotionID;
                        result.ID_Type_Product = messure.Type_ProductID;
                        result.LastUpdate = DateTime.Now;
                        db.SaveChanges();
                        //mainWindow.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Product was \nupdate successfuly", mainWindow));
                    }
                }
                return;
            }

        }


        public void AddProduct(object obj)
        {  
            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (edit)
                {
                 db.ObjectStateManager.ChangeObjectState(product, System.Data.EntityState.Modified);        
                    db.SaveChanges();
                    MessageBox.Show("Product changed");
                }
                else
                {
                    Product Addproduct = new Product()
                    {
                        Name = product.Name,
                        Short_name = product.Short_name,
                        Description = product.Description,
                        Description1 = product.Description1,
                        ID_Category = product.Category.CategoryID,
                        ID_Distributor = product.Distributor.DistributorID,
                        ID_Developer = product.Developer.DeveloperID,
                        ID_Type_Product = product.Type_Product.Type_ProductID,
                        List_price = product.List_price,
                        Stock_price = product.Stock_price,
                        StandartPrice = product.StandartPrice,
                        SellStartDate = product.SellStartDate,
                        SellEndDate = product.SellEndDate,
                        LastUpdate = DateTime.Now,
                        QT_InStock = product.QT_InStock,
                        Restriction_age = product.Restriction_age
                    };

                    db.Products.AddObject(Addproduct);
                    db.SaveChanges();
                    MessageBox.Show("Product added");
                    product = new Product();
                }
            }
            Mediator.Notify("AddProductView", null);
        }

        #region IPageViewModel interface

        public string Name
        {
            get { return "Add product"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.ProductManagement; }
        }
        #endregion
    }
}
