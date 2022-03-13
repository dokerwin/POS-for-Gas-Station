using Gas_station.Receipt_managment;
using MWS.Helper_Classes;
using MWS.Product_managment;
using MWS.Users_managment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MWS.MWSUtil.Enums;

namespace MWS.MainMenu
{
    public class MainViewModel : ObservableObject, IPageViewModel, INotifyPropertyChanged
    {


        public int _totalProducts { get; set; } = 0;
        public int _totalCustomers { get; set; } = 0;
        public int _totalTransactions { get; set; } = 0;



        public MainViewModel()
        {
            _totalProducts = ProductHandler.GetNumberOfProducts();
            _totalCustomers = UserHandler.GetNumberOfCustomers();
            //_totalTransactions = ReceiptHanler.GetTotalReceipts();
        }

        #region IPageViewModel interface
        public string Name
        {
            get { return "Main"; }
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