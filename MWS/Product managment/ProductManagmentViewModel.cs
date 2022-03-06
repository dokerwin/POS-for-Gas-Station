using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<Product> products { get; set; } = new ObservableCollection<Product>();


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
                return addProductButton ?? (addProductButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddProductView", "");
                }));
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
                foreach(var product in db.Products.Include("Developer").Include("Distributor").Include("Category").ToList())
                {
                    products.Add(product);
                }
            }

            buttonDelete = new RelayCommand(DeleteProduct);
            buttonEdit   = new RelayCommand(EditProduct);
            findProductButton = new RelayCommand(FindProduct);
        }


        public void FindProduct(object obj)
        {


        }

        public void EditProduct(object obj)
        {
           Mediator.Notify("AddProductView", obj);
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

