using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
using System.ComponentModel;

namespace MWS.Users_managment.ViewModels
{
    public class AddEmployeeModelView : ObservableObject, IPageViewModel, INotifyPropertyChanged, IObserver
    {
        #region Constructor/Destructors

        public AddEmployeeModelView(object obj = null)
        {
            if (obj is Observer)
            {
                observer = (Observer)obj;
                observer.Attach(this);
            }
            UpdateModels();
        }

        #endregion

        #region Public members
        public List<String> SexList { get; set; } = new List<string> { "Male", "Feamle" };
        public List<TypeOfEmployment> EmploymentList 
        {
            get
            {
            if (_employmentList == null)
                {
                    return new List<TypeOfEmployment>();
                }
            return _employmentList;
            }
            set
            { 
                _employmentList = value;
                OnPropertyChanged(nameof(EmploymentList));
            }
        }
        public TypeOfEmployment _typeOfEmployment { get; set; } = new TypeOfEmployment();
        public List<EmPosition> PositionList 
        {
            get
            {
                if (_positionList == null)
                {
                    return new List<EmPosition>();
                }
                return _positionList;
            }
            set
            {
                _positionList = value;
                OnPropertyChanged(nameof(PositionList));
            }
        }
        public EmPosition _position { get; set; } = new EmPosition();
        public List<Staff> StaffList
        {
            get
            {
                if (_staffList == null)
                {
                    return new List<Staff>();
                }
                return _staffList;
            }
            set
            {
                _staffList = value;
                OnPropertyChanged(nameof(StaffList));
            }
        }
        public Staff _staff { get; set; } = new Staff();
        public Cashier cashier
        {
            get
            {
                if (_cashier == null)
                {
                    return new Cashier()
                    {
                        Person = new Person()
                    };
                }
                return _cashier;
            }
            set
            {
                _cashier = value;
                OnPropertyChanged(nameof(cashier));
            }
        }
   
        public bool _editMode = false;
        public string Login { get; set; } = "Admin";
        public string Password { get; set; } = "Admin";

        #endregion

        #region Public methods

        public void Update(ISubject subject)
        {
            UpdateModels();
        }
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

        #endregion

        #region Private methods

        private void SaveEmployee()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                if (_editMode)
                {
                    try
                    {
                        db.Attach(cashier);
                        db.ObjectStateManager.ChangeObjectState(cashier, System.Data.EntityState.Modified);
                        db.SaveChanges();
                        MessageBox.Show("Employee data changed");
                    }
                    catch (Exception ex)
                    {
                        _editMode = false;
                        MessageBox.Show("Please check data");
                    }
                    cashier = null;
                    _editMode = false;
                    observer.Notify();
                }
                else
                {
                    cashier.Hire_date = DateTime.Now;
                    cashier.ID_Type_of_employment = _typeOfEmployment.TypeOfEmploymentID;
                    cashier.IDEmPosition = _position.EmPositionID;
                    cashier.Id_Staff = _staff.StaffID;
                    try
                    {
                        db.People.AddObject(cashier.Person);
                        db.SaveChanges();
                        StoredPocedures.AddLoginProc(cashier.CashierID, Login, Password, out string outResult);
                        if (outResult != "Success")
                        {
                            MessageBox.Show("Please check login or password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check data");
                    }

                    observer.Notify();
                }
            }
        }

        private void UpdateModels()
        {
            EmploymentList = new List<TypeOfEmployment>( EmployeeHelper.GetAllEmploymentTypes());
            PositionList = EmployeeHelper.GetAllEmployeePostion();
            StaffList = EmployeeHelper.GetAllStaffType();
        }

        #endregion

        #region Private variables
        private Cashier _cashier;
        private List<TypeOfEmployment> _employmentList;
        private List<EmPosition> _positionList;
        private List<Staff> _staffList;  

        private Observer observer;
        private ICommand _addEmployeeButton;

        #endregion

        #region IPageViewModel interface

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
    }
}
