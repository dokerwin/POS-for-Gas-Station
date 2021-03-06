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
namespace MWS.Product_managment.Developer_managment
{
    public class DevelopersManagmentViewModel : ObservableObject, IPageViewModel
    {

        public ObservableCollection<Developer> developers { get; set; } = DeveloperHandler.GetAllDeveloperList();


        #region IComand buttons
        private ICommand addDeveloperButton { get; set; }
        private ICommand findDeveloperButton { get; set; }
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

        public ICommand AddDeveloperButton
        {
            get
            {
                return addDeveloperButton ?? (addDeveloperButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddDeveloperView", "");
                }));
            }
        }
        public ICommand FindProductButton
        {
            get
            {
                return findDeveloperButton;
            }
            set
            {
                findDeveloperButton = value;
            }
        }
        #endregion



        public DevelopersManagmentViewModel(object obj = null)
        {
            buttonDelete = new RelayCommand(DeleteDeveloper);
            buttonEdit = new RelayCommand(EditDeveloper);
            findDeveloperButton = new RelayCommand(FindDeveloper);
        }


        public void FindDeveloper(object obj)
        {


        }

        public void EditDeveloper(object obj)
        {
            Mediator.Notify("AddDeveloperViewEdit", obj);
        }

        public void DeleteDeveloper(object obj)
        {
            var item = obj as Developer;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var devel = db.Developers.FirstOrDefault(i => i.DeveloperID == item.DeveloperID);
                    db.Developers.DeleteObject(devel);
                    db.SaveChanges();
                }
            }
            Mediator.Notify("AddDeveloperView", null);
        }
        public void AddDeveloper(object obj)
        {

        }
        #region IPageViewModel interface
        public string Name
        {
            get { return "Developer management"; }
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
