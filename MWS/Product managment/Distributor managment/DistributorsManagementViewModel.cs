using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;

namespace MWS.Product_managment.Distributor_managment
{
    internal class DistributorsManagementViewModel : ObservableObject, IPageViewModel
    {
        public ObservableCollection<Distributor> distributors { get; set; } = DistributorHandler.GetAllDsitributorList();
        #region IComand buttons
        private ICommand addDistributorButton { get; set; }
        private ICommand findDistributorButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }
        #endregion

        #region IComand public methods buttons

        public ICommand ButtonEdit
        {
            get
            {
                return buttonEdit;
            }
            set
            {
                buttonEdit = value;
            }
        }

        public ICommand ButtonDelete
        {
            get
            {
                return buttonDelete;
            }
            set
            {
                buttonDelete = value;
            }
        }

        public ICommand AddDistributorButton
        {
            get
            {
                return addDistributorButton ?? (addDistributorButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddDistributorView", "");
                }));
            }
        }
        public ICommand FindProductButton
        {
            get
            {
                return findDistributorButton;
            }
            set
            {
                findDistributorButton = value;
            }
        }
        #endregion

        public DistributorsManagementViewModel(object obj = null)
        {
            buttonDelete           = new RelayCommand(DeleteDistributor);
            buttonEdit             = new RelayCommand(EditDistributor  );
            findDistributorButton  = new RelayCommand(FindDistributor  );
        }


        public void FindDistributor(object obj)
        {


        }

        public void EditDistributor(object obj)
        {
            Mediator.Notify("AddDistributorViewEdit", obj);
        }

        public void DeleteDistributor(object obj)
        {
            var item = obj as Distributor;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var distrib = db.Distributors.FirstOrDefault(i => i.DistributorID == item.DistributorID);
                    db.Distributors.DeleteObject(distrib);
                    db.SaveChanges();
                }
            }
            Mediator.Notify("AddDistributorView", null);
        }

        #region IPageViewModel interface
        public string Name
        {
            get { return "Distributors management"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.ProductManagement; }
        }
        #endregion
    }
}

