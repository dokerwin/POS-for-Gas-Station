using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
namespace MWS.Product_managment.Developer_managment
{
    public class AddDeveloperViewModel:ObservableObject, IPageViewModel
    {
        public Developer developer { get; set; } = new Developer();

        private ICommand _addDeveloperButton { get; set; }

        private bool edit = false;
        public  ICommand AddDeveloperButton
        {
            get
            {
                return _addDeveloperButton;
            }
            set
            {
                _addDeveloperButton = value;
            }
        }

        public AddDeveloperViewModel(object obj = null, bool edit = false)
        {
            this.edit = edit; 
            if(obj != null)
            {
                developer = obj as Developer;
            }
            _addDeveloperButton = new RelayCommand(AddDeveloper);
        }



        void AddDeveloper(object obj)
        {

            //Company comp = new Company()
            //{
            //    Name = company.Name,
            //    KRS = company.KRS,
            //    REGON = company.REGON,
            //    NIP = company.NIP,
            //    Email1 = company.Email1,
            //    Email2 = company.Email2,
            //    Adres_country = company.Adres_country,
            //    Adress_street = company.Adress_street,
            //    Adress_city = company.Adress_city,
            //    Adress_zip = company.Adress_zip,
            //    Adress_level = company.Adress_level,
            //    Adress_build = company.Adress_build,
            //    Phone1 = company.Phone1,
            //    Phone2 = company.Phone2,
            //    Tax = company.Tax,
            //    WWW = company.WWW,
            //    RegisterDate = DateTime.Now,
            //    Additional1 = company.Additional1,
            //    Additional2 = company.Additional2,

            //};

            using (Gas_stationDb db = new Gas_stationDb())
            {

                if (edit)
                {
                    db.ObjectStateManager.ChangeObjectState(developer, System.Data.EntityState.Modified);
                    db.SaveChanges();
                    MessageBox.Show("Product changed");
                }
                else
                {
                    db.Companies.AddObject(developer.Company);
                    db.SaveChanges();
                    Developer _developer = new Developer()
                    {
                        Name = developer.Company.Name,
                        ID_Company = developer.Company.CompanyID
                    };
                    db.Developers.AddObject(_developer);
                }
                MessageBox.Show("Developer added");
                Mediator.Notify("AddDeveloperView", null);
            }

        }

        #region IPageViewModel interface

        public string Name
        {
            get { return "Add developer"; }
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
