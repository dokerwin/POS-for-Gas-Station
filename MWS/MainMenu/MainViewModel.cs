using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.MainMenu
{
    public class MainViewModel : ObservableObject, IPageViewModel, INotifyPropertyChanged
    {
        public string Name
        {
            get
            {
                return "Test";
            }
        }
        public string ButtonPage
        {
            get { return "Assets/addProduct.png"; }
        }
    }
}