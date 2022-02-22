using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MWS.Product_managment.Developer_managment
{
    public class AddDeveloperViewModel:ObservableObject, IPageViewModel
    {
        public Developer developer { get; set; } = new Developer();
        public Company   company { get; set; } =   new  Company();

        private ICommand _addDeveloperButton { get; set; }

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

        public AddDeveloperViewModel()
        {
            _addDeveloperButton = new RelayCommand(AddDeveloper);
        }



        void AddDeveloper(object obj)
        {

            Company comp = new Company()
            {
                Name = company.Name,
                KRS = company.KRS,
                REGON = company.REGON,
                NIP = company.NIP,
                Email1 = company.Email1,
                Email2 = company.Email2,
                Adres_country = company.Adres_country,
                Adress_street = company.Adress_street,
                Adress_city = company.Adress_city,
                Adress_zip = company.Adress_zip,
                Adress_level = company.Adress_level,
                Adress_build = company.Adress_build,
                Phone1 = company.Phone1,
                Phone2 = company.Phone2,
                Tax = company.Tax,
                WWW = company.WWW,
                RegisterDate = DateTime.Now,
                Additional1 = company.Additional1,
                Additional2 = company.Additional2,

            };

            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Companies.Add(comp);
                db.SaveChanges();
                MessageBox.Show("Developer added");
                company = new Company();
                Developer developer = new Developer()
                {
                    Name = company.Name,
                    ID_Company = company.CompanyID
                };
                db.Developers.Add(developer);

            }

        }

        public string Name
        {
            get
            {
                return "Add developer";
            }
        }
        public string ButtonPage
        {
            get { return "Assets/addProduct.png"; }
        }
    }
}
