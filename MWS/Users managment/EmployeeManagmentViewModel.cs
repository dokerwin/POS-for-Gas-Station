using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS.Users_managment
{
    public class EmployeeManagmentViewModel : ObservableObject, IPageViewModel
    {
        #region IComand buttons

        private ICommand addCustomerButton   { get; set; }
        private ICommand addEmployeeButton   { get; set; }
        private ICommand allCustomersButton  { get; set; }
        private ICommand allEmployeesButton  { get; set; }
        private ICommand hireEmployeeButton  { get; set; }
        public ICommand AddEmployeeButton
        {
            get
            {
                return addEmployeeButton ?? (addEmployeeButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddEmpoyeeView", "");
                }));
            }
        }
        public ICommand AllEmployeesButton
        {
            get
            {
                return allEmployeesButton ?? (allEmployeesButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AllEmployeesView", "");
                }));
            }
        }
        public ICommand HireEmployeeButton
        {
            get
            {
                return hireEmployeeButton ?? (hireEmployeeButton = new RelayCommand(x =>
                {
                    Mediator.Notify("HireEmployeesView", "");
                }));
            }
        }
        public ICommand AddCustomerButton
        {
            get
            {
                return addCustomerButton ?? (addCustomerButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddCustomerView", "");
                }));
            }
        }
        public ICommand AllCustomersButton
        {
            get
            {
                return allCustomersButton ?? (allCustomersButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AllCustomersView", "");
                }));
            }
        }

        #endregion


        #region Button fuctions

        #endregion
        public string Name
        {
            get { return "User managmnet"; }
        }
        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

    }
}
