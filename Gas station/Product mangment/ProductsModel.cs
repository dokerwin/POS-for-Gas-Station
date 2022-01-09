using Gas_station.Product_management;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Gas_station.Product_mangment
{
    class ProductsModel
    {
        public int productID { get; set; }
    

        private IList<Product> _productsList = ProductUtill.AllProducts();

        public ProductsModel()
        {
            MyCommand = new DelegateCommand(FindProduct);
            AddProductBtn = new  DelegateCommand(AddProduct);
        }

        private void FindProduct()
        {
           
        }
        private void AddProduct()
        {
            MainWindow main = Util.Util.MainPagePointer();
            main.Main.Content = new AddProduct(main, new Product());
        }

        public ICommand MyCommand { get; set; }
        public ICommand AddProductBtn { get; set; }
        public IList<Product> ProductsList
        {
            get { return _productsList; }
            set { _productsList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                _selectedProduct = value;
                OnProductSelectedChanged();
            }
        }


        protected virtual void OnProductSelectedChanged()
        {
            if (SelectedProductChanged != null)
            {
                SelectedProductChanged(this, EventArgs.Empty);
                MainWindow main = Util.Util.MainPagePointer();
                main.Main.Content =new AddProduct(main, SelectedProduct);
            }

        }

        public event System.EventHandler SelectedProductChanged;


        public IEnumerable<Product> _product { get; set; }
        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

           
           
           

            #endregion
        }
    }
}
