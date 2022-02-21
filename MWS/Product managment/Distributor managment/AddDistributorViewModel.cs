using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Product_managment.Distributor_managment
{
    public class AddDistributorViewModel: ObservableObject, IPageViewModel
    {
        private ICommand addDeveloperButton { get; set; }

        public ICommand AddDeveloperButton
        {
            get
            {
                return addDeveloperButton;
            }
            set
            {
                addDeveloperButton = value;
            }
        }
        public string Name
        {
            get
            {
                return "Add distributor";
            }
        }
        public string ButtonPage
        {
            get { return "Assets/addProduct.png"; }
        }
    }
}
