using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MWS.Product_managment
{
    public class ProductManagmentViewModel : ObservableObject, IPageViewModel
    {

        public List<Product> products { get; set; } = new List<Product>();


        #region IComand buttons

        private ICommand addProductButton { get; set; }
        private ICommand findProductButton { get; set; }
        private ICommand buttonDelete { get;  set; }
        private ICommand buttonEdit  { get;  set; }


        #endregion

        #region IComand public methods buttons

        public ICommand ButtonEdit
        {
            get
            {
                return buttonEdit;
            }
            set
            {
               buttonEdit = value;
            }
        }

        public ICommand ButtonDelete
        { 
            get
            {
                return buttonDelete;
            }
            set
            {
                buttonDelete = value;
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
        public ICommand FindProductButton
        {
            get
            {
                return findProductButton;
            }
            set
            {
                findProductButton = value;
            }
        }
        #endregion

        public string Name
        {
            get
            {
                return "Products";
            }
        }

        public ProductManagmentViewModel( )
        {
            using(Gas_stationDb db = new Gas_stationDb()) 
            {
                products = db.Products.Include("Developer").Include("Distributor").Include("Category").ToList();  
            }

            buttonDelete = new RelayCommand(DeleteProduct);
            buttonEdit   = new RelayCommand(EditProduct);
            addProductButton   = new RelayCommand(AddProduct);
            findProductButton = new RelayCommand(FindProduct);
        }


        public void FindProduct(object obj)
        {


        }

        public void EditProduct(object obj)
        {

        }

        public void DeleteProduct(object obj)
        {
            var item = obj as Product;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var prod = db.Products.FirstOrDefault(i=> i.ProductID == item.ProductID);
                    db.Products.Remove(prod);

                    db.SaveChanges();
                }
            }
        }


        public void AddProduct(object obj)
        {
           
        }
        public string ButtonPage
        {
            get { return "Assets/list.png"; }
        }
    }
}

