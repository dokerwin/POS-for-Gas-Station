using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
namespace MWS.Shift_managment
{
    internal class ShiftDetailsViewModel : ObservableObject, IPageViewModel
    {
        public Shift actualShift = new Shift();

       public ShiftDetailsViewModel(Shift shift)
       {
            actualShift = shift;
       }

        #region IPageViewModel interface
        public string Name
        {
            get { return "Shift details"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.ShiftManagement; }
        }
        #endregion
    }
}
