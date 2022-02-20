using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Users_managment
{
    public class AddEmployeeModelView : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "Add employee"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }
    }
}
