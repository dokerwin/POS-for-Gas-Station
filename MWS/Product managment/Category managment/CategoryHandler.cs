using MWS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;

namespace MWS.Product_mangment.Category_managment
{
    public class CategoryHandler
    {
        public static ObservableCollection<Category> GetAllCategories()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
              return new ObservableCollection<Category>(db.Categories);
            }
        }
        public List<Product> GetAllProductByCategory(Category category)
        {
            List<Product> a = new List<Product>();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                foreach(Product p in db.Products.Where(r => r.Category.CategoryID == category.CategoryID).ToList())
                {
                    if (p.Category != null)
                    {
                        a.Add(p);
                    }
                }
            }
            return a;
        }
        public Category GetCategoryById(int CategoryID)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Categories.FirstOrDefault(r => r.CategoryID == CategoryID);
            }
        }
    }
}
