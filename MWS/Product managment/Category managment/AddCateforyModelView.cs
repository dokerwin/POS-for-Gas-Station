using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Product_managment.Category_managment
{
   public class AddCateforyModelView : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get
            {
                return "Add category";
            }
        }
        public string ButtonPage
        {
            get { return "Assets/addProduct.png"; }
        }
    }
}
