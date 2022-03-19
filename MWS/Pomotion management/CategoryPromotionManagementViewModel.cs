using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;

namespace MWS.Pomotion_management
{
    internal class CategoryPromotionManagementModelView : ObservableObject, IPageViewModel
    {
        public ObservableCollection<CatPromotion> promotions { get; set; } = new ObservableCollection<CatPromotion>();

        public  CatPromotion catPromotion { get; set; } = new CatPromotion();

        #region IComand buttons
        private ICommand addPromoButton { get; set; }
        private ICommand findPromoButton { get; set; }
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

        public ICommand AddPromoButton
        {
            get
            {
                return addPromoButton;
            }
            set
            {
                addPromoButton = value;
            }
        }
        public ICommand FindPromoButton
        {
            get
            {
                return findPromoButton;
            }
            set
            {
                findPromoButton = value;
            }
        }
        #endregion
        public CategoryPromotionManagementModelView()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                foreach (var promo in db.CatPromotions.Include("Category").ToList())
                {
                    promotions.Add(promo);
                }
            }
            buttonDelete = new RelayCommand(DeletePromo);
            buttonEdit = new RelayCommand(EditPromo);
            findPromoButton = new RelayCommand(FindPromo);
            addPromoButton = new RelayCommand(AddPromo);
        }
        public void FindPromo(object obj)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.CatPromotions.Add(catPromotion);
            }
        }
        public void AddPromo(object obj)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.CatPromotions.Add(catPromotion);
            }
        }
        public void EditPromo(object obj)
        {
            Mediator.Notify("CategoryPromotionManagementViewEdit", obj);
        }
        public void DeletePromo(object obj)
        {
            var item = obj as ProdPromotion;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var promo = db.ProdPromotions.FirstOrDefault(i => i.PromotionID == item.PromotionID);
                    db.ProdPromotions.Remove(promo);

                    db.SaveChanges();
                }
            }
            Mediator.Notify("CategoryPromotionManagementView", null);
        }

        #region IPageViewModel interface

        public string Name
        {
            get { return "Products managements"; }
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
