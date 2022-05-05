using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MWS.MWSUtil.Enums;

namespace MWS.Fuel_managment
{
    internal class FuelManagemtViewModel : ObservableObject, IPageViewModel, INotifyPropertyChanged
    {




        #region IPageViewModel interface
        public string Name
        {
            get { return "Fuel manegement"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.Main; }
        }
        #endregion
    }
}
