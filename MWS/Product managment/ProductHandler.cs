using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Product_managment
{
    public class ProductHandler
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
                return new ObservableCollection<Product>(db.Products);
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
    }
}
