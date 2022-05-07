using MWS.Helper_Classes;
using MWS.MWSUtil;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TorasSQLHelper;
using static MWS.MWSUtil.Enums;

namespace MWS.Users_managment.ViewModels
{
    public class AllEmployeesViewModel : ObservableObject, IPageViewModel, IObserver
    {
        private ObservableCollection<Cashier> _emplList;
        public ObservableCollection<Cashier> _cashierList
        {
            get { return _emplList; }
            set
            {
                _emplList = value;
                RaisePropertyChanged("_cashierList");
            }
        } 

        private FilterType filter;

        public FilterType Filter
        {
            get { return filter; }
            set
            {
                if (filter != value)
                {
                    filter = value;
                    OnPropertyChanged(nameof(Filter));
                    UpdateEmployeeList(filter);
                }
            }
        }

        public Cashier cashier { get; set; } = new Cashier()
        {
            Person = new Person()
        };

        private ICommand findEmployeeButton { get; set; }
        private ICommand buttonDelete { get; set; }
        private ICommand buttonEdit { get; set; }
        private ICommand addEmployeeButton { get; set; }

        #region IComand buttons
        public ICommand AddEmployeeButton
        {
            get
            {
                return addEmployeeButton ?? (addEmployeeButton = new RelayCommand(x =>
                {
                    Mediator.Notify("AddEmpoyeeView", null);
                }));
            }
        }

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


        public ICommand FindEmployeeButton
        {
            get
            {
                return findEmployeeButton;
            }
            set
            {
                findEmployeeButton = value;
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
        #endregion

        #region Constructors
        public AllEmployeesViewModel(Observer observer)
        {
            observer.Attach(this);
            buttonDelete = new RelayCommand(FireEmployee);
            buttonEdit = new RelayCommand(EditEmployee);
            findEmployeeButton = new RelayCommand(FindEmployee);
            _cashierList = EmployeeHelper.GetAllEmployees(FilterType.All);

        }
        #endregion

        #region  Button's method
        private void EditEmployee(object cashier)
        {
            Mediator.Notify("AddEmployeeViewEdit", cashier);
        }

        private void FireEmployee(object employee)
        {
            var item = employee as Cashier;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    Cashier emp = db.Cashiers.Include("Person").FirstOrDefault(i => i.CashierID == item.CashierID);
                    var person = db.People.FirstOrDefault(i => i.PersonID == item.ID_Person);
                    emp.Fire_date = DateTime.Now;

                    db.ObjectStateManager.ChangeObjectState(emp, System.Data.EntityState.Modified);

                    db.SaveChanges();
                    MessageBox.Show("Employee was fired");
                    UpdateEmployeeList(FilterType.Fired);
                }
            }
        }

        public void UpdateEmployeeList(object sender, MyEventArgs e)
        {
            UpdateEmployeeList(FilterType.Active);
        }

        public void UpdateEmployeeList(FilterType filterType)
        {
            _cashierList = EmployeeHelper.GetAllEmployees(filterType);
        }

        private void FindEmployee(object cust)
        {
            _cashierList.Clear();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var find = db.Cashiers.Include("Person").FirstOrDefault(i => i.Person.Name == cashier.Person.Name);
                if (find != null)
                {
                    _cashierList.Clear();
                    _cashierList.Add(find);
                }
            }
        }

        public void Update(ISubject subject)
        {
            UpdateEmployeeList(FilterType.All);
        }
        #endregion

        #region IPageViewModel interface

        public string Name
        {
            get { return "All employees"; }
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
    }
}


