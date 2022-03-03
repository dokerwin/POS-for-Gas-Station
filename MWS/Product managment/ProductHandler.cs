using System;
using System.Collections.Generic;
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
    }
}
