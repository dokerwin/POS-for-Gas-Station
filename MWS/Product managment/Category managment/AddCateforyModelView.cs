
using MWS.Helper_Classes;
using MWS.Product_mangment.Category_managment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Product_managment.Category_managment
{
   public class AddCateforyModelView : ObservableObject, IPageViewModel
    {

        public Category category { get; set; } = new Category();
        public ObservableCollection<Category> ctaegoryList { get; set; } = CategoryHandler.GetAllCategories();

        #region IComand buttons
        private ICommand saveCategoryButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }
        #endregion


        public AddCateforyModelView(object obj = null)
        {
            category = obj as Category;
            buttonDelete = new RelayCommand(DeleteCategory);
            buttonEdit = new RelayCommand(EditCategory);
            saveCategoryButton = new RelayCommand(SaveCategory);
        }




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

        public ICommand SaveCategoryButton
        { 
            get
            {
                return saveCategoryButton;
            }
            set
            {
                saveCategoryButton = value;
            }
        }
        #endregion


        private void SaveCategory(object obj)
        {
            // category = obj as Category;
            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (category.CategoryID == 0)
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(category).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void EditCategory(object obj)
        {
            Mediator.Notify("AddCategoryView", obj);
        }

        private void DeleteCategory(object obj)
        {
            var item = obj as Category;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    db.Categories.Remove(db.Categories.FirstOrDefault(i => i.CategoryID == item.CategoryID));
                    db.SaveChanges();
                }
            }
        }

        public string Name
        {
            get
            {
                return "Add category";
            }
        }
        public string ButtonPage
        {
            get { return "Assets/addProduct.png"; }
        }
    }
}
