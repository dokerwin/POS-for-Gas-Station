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
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;

namespace MWS.Product_managment
{
    public class ProductManagmentViewModel : ObservableObject, IPageViewModel, IObserver
    {
        private ObservableCollection<Product> _products = null;

        public string _searchParametr { get; set; }
        public Observer observer = null;
        public ObservableCollection<Product> products
        {
            get
            {
                if(_products is null)
                {
                    _products = ProductHelper.GetAllProducts();
                }
                return _products;
            }
            set
            {
                _products = value;
                RaisePropertyChanged(nameof(products));
            }
        }


        #region IComand buttons

        private ICommand addProductButton { get; set; }
        private ICommand findProductButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }

        #endregion

        #region IComand public methods buttons

        public ICommand ButtonEdit
        {
            get
            {
                return buttonEdit ?? (buttonEdit = new RelayCommand(EditProduct));
            }
        }

        public ICommand ButtonDelete
        {
            get
            {
                return buttonDelete ?? (buttonDelete = new RelayCommand(DeleteProduct));
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
                return findProductButton ?? (findProductButton = new RelayCommand(FindProduct));
            }
        }

        #endregion

        public ProductManagmentViewModel(Observer observer)
        {
            this.observer = observer;
            UpdateProductList();
        }

        public void FindProduct(object obj)
        {
            products = ProductHelper.FindProductByNameOrBarcode(_searchParametr);
        }

        public void EditProduct(object obj)
        {
            Mediator.Notify("AddProductViewEdit", obj);
        }

        public void DeleteProduct(object obj)
        {
            var item = obj as Product;
            if (item != null)
            {
                try 
                {
                    using (Gas_stationDb db = new Gas_stationDb())
                    {
                        var prod = db.Products.FirstOrDefault(i => i.ProductID == item.ProductID);
                        db.Products.DeleteObject(prod);
                        db.SaveChanges();
                    }
                    UpdateProductList();
                }
                catch
                {

                } 
            }
        }

        public void Update(ISubject subject)
        {
           UpdateProductList();
        }

        private void UpdateProductList()
        {
            products = ProductHelper.GetAllProducts();
        }

        #region IPageViewModel interface

        public string Name
        {
            get { return "Products managements"; }
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

