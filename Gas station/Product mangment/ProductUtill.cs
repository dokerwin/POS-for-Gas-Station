using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Product_mangment
{
    public static class ProductUtill
    {
        public static ObservableCollection<Product> AllProducts()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                ObservableCollection<Product> observable = new ObservableCollection<Product>();
                foreach (var a in db.Products.Where(t => !String.IsNullOrEmpty(t.Category.Name)).ToList())
                {
                    if (!string.IsNullOrEmpty(a.Category.Name)
                        && !string.IsNullOrEmpty(a.Developer.Name)
                        && !string.IsNullOrEmpty(a.Distributor.Name))
                        observable.Add(a);
                }
                return observable;
            }
        }



        public static Product FindProduct(int productID)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var a = db.Products.FirstOrDefault(t =>t.ProductID == productID);
                if (a != null)
                {
                    if (!string.IsNullOrEmpty(a.Category.Name)
                        && !string.IsNullOrEmpty(a.Developer.Name)
                        && !string.IsNullOrEmpty(a.Distributor.Name))
                    {
                        return a;
                    }
                } 
            }
                return new Product();
        }
    }
}
