using MWS.Helper_Classes;
using TorasPromotion;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
namespace MWS.Pomotion_management
{
    public class PromotionManagementViewModel : ObservableObject, IPageViewModel
    {
           PromoProductHandler promoNET = null;
            public ObservableCollection<ProdPromotion> promotions { get; set; } = new ObservableCollection<ProdPromotion>();

        public ProdPromotion prodPromotion { get; set; } = new ProdPromotion();


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
        public PromotionManagementViewModel(object obj)
        {
            if(obj != null)
            prodPromotion = obj as ProdPromotion;

            promoNET = new PromoProductHandler();

            int a =   promoNET.PromoTest();
            buttonDelete      = new RelayCommand  (DeletePromo);
            buttonEdit        = new RelayCommand  (EditPromo  );
            findPromoButton   = new RelayCommand  (FindPromo  );
            addPromoButton    = new RelayCommand  (AddPromo   );
        }
        public void FindPromo(object obj)
        {
         
        }
        public void AddPromo(object obj)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.ProdPromotions.AddObject(prodPromotion);
                db.SaveChanges();
            }
        }
        public void EditPromo(object obj)
        {
            Mediator.Notify("PromotionManagementViewEdit", obj);
        }
        public void DeletePromo(object obj)
        {
            var item = obj as ProdPromotion;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    var promo = db.ProdPromotions.FirstOrDefault(i => i.PromotionID == item.PromotionID);
                    db.ProdPromotions.Attach(promo);
                    db.DeleteObject(promo);
                    db.SaveChanges();
                }
            }
            Mediator.Notify("PromotionManagementView", null);
        }

        #region IPageViewModel interface

        public string Name
        {
            get { return "Product promotion"; }
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
