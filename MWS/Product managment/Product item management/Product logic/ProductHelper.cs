using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;

namespace MWS.Product_managment
{
    public class ProductHelper
    {
        public static int GetNumberOfProducts()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Products.Count();
            }
        }
        public static ObservableCollection<Product> GetAllProducts()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Product>
                    (db.Products.Include("Developer").Include("Distributor").Include("Category").ToList());
            }
        }
        public static ObservableCollection<Product> GetAllProductsByCategory(Category category)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Product>(db.Products.Where(c=>c.Category == category));
            }
        }
        public static ObservableCollection<Product> GetAllProductsByCategory(int categoryID)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Product>(db.Products.Where(c => c.ID_Category == categoryID));
            }
        }

        public static ObservableCollection<Product> FindProductByNameOrBarcode(string searchParam)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var find = db.Products.Where(i => i.Name == searchParam
                || i.Short_name == searchParam);
                if (find != null)
                {
                    return new ObservableCollection<Product>(find);
                }
            }
            return new ObservableCollection<Product>();
        }


        public static void DeleteProduct (int IdProduct)
        {
          
        }


    }
}
