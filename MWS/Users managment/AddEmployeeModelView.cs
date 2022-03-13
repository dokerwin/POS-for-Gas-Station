using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;

namespace MWS.Users_managment
{
    public class AddEmployeeModelView : ObservableObject, IPageViewModel
    {
        # region IPageViewModel interface

        public string Name
        {
            get { return "Add employee"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.CustomerManagemnet; }
        }
        #endregion


        private ICommand _addEmployeeButton;

        public List<String> SexList { get; set; } = new List<string> { "Male", "Feamle" };



        public Cashier _cashier { get; set; } = new Cashier()
        {
            Person = new Person(),
            TypeOfEmployment = new TypeOfEmployment()
        };

        public ICommand AddEmployeeButton
        {
            get
            {
                if (_addEmployeeButton == null)
                {
                    _addEmployeeButton = new RelayCommand(
                        param => SaveEmployee()
                    );
                }
                return _addEmployeeButton;
            }
        }

        private void SaveEmployee()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Cashiers.Add(_cashier);              
            }
        }
    }
}
