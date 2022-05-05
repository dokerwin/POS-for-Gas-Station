using MWS.Helper_Classes;
using MWS.Product_mangment.Category_managment;
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
    internal class CategoryPromotionManagementModelView : ObservableObject, IPageViewModel
    {
        public ObservableCollection<CatPromotion> promotions { get; set; } = new ObservableCollection<CatPromotion>();


        public Category SelectedCategory
        {
            get
            {
                if (this.SelectedCategory == null)
                {
                    return new Category();
                }
                return SelectedCategory;
            }
            set
            {
                SelectedCategory = value;
              
            }
        }
        public CatPromotion catPromotion { get; set; }  = new CatPromotion();
        public ObservableCollection<Category> categories { get; set; } = CategoryHandler.GetAllCategories();

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
            promotions = new ObservableCollection<CatPromotion>( TorasPromotion.Common.AllCategoryPromotion());
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
                db.CatPromotions.AddObject(catPromotion);
            }
        }
        public void AddPromo(object obj)
        {
             //catPromotion.
            if (catPromotion.ID_Category != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {   
                    db.CatPromotions.AddObject( new CatPromotion()
                    {
                        ID_Category =  catPromotion.ID_Category,
                        Prom_type = catPromotion.Prom_type,
                        Prom_start= (DateTime)catPromotion.Prom_start,
                        Prom_end = (DateTime)catPromotion.Prom_end,
                        Prom_discount= catPromotion.Prom_discount
                    });
                    db.SaveChanges();
                }
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
                    var promo = db.CatPromotions.FirstOrDefault(i => i.PromotionID == item.PromotionID);
                    db.CatPromotions.Attach(promo);
                    db.DeleteObject(promo);
                    db.SaveChanges();
                }
            }
            Mediator.Notify("CategoryPromotionManagementView", null);
        }

        #region IPageViewModel interface
        public string Name
        {
            get { return "Category promotion"; }
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
