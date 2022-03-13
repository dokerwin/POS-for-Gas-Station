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

namespace MWS.Product_managment.Distributor_managment
{
    public class AddDistributorViewModel: ObservableObject, IPageViewModel
    {
        private bool edit = false;
        public Distributor distributor { get; set; } = new Distributor(); 
        private ICommand _addDistributorButton { get; set; }

        public ICommand AddDistributorButton
        {
            get
            {
                return _addDistributorButton;
            }
            set
            {
                _addDistributorButton = value;
            }
        }

        public AddDistributorViewModel(object obj = null, bool edit = false)
        {
            this.edit = edit;
            if(obj != null)
            {
                distributor = (Distributor)obj;
            }
            _addDistributorButton = new RelayCommand(AddDistibutor);
        }

        void AddDistibutor(object obj)
        {

           //Company comp = new Company()
           // {
           //     Name = company.Name,
           //     KRS = company.KRS,
           //     REGON = company.REGON,
           //     NIP = company.NIP,
           //     Email1 = company.Email1,
           //     Email2 = company.Email2,
           //     Adres_country = company.Adres_country,
           //     Adress_street = company.Adress_street,
           //     Adress_city = company.Adress_city,
           //     Adress_zip = company.Adress_zip,
           //     Adress_level = company.Adress_level,
           //     Adress_build = company.Adress_build,
           //     Phone1 = company.Phone1,
           //     Phone2 = company.Phone2,
           //     Tax = company.Tax,
           //     WWW = company.WWW,
           //     RegisterDate = DateTime.Now,
           //     Additional1 = company.Additional1,
           //     Additional2 = company.Additional2,
         
           // };

            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (edit)
                {
                    db.Entry(distributor).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Distributor changed");
                }
                else
                {
                    db.Companies.Add(distributor.Company);
                    db.SaveChanges();
                    MessageBox.Show("Distributor added");
                    Distributor _distributor = new Distributor()
                    {
                        Name = distributor.Company.Name,
                        ID_Company = distributor.Company.CompanyID
                    };
                    db.Distributors.Add(_distributor);
                }
                Mediator.Notify("AddDistributorView", null);
            }
        }

        #region IPageViewModel interface
        public string Name
        {
            get { return "Add distributor"; }
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
