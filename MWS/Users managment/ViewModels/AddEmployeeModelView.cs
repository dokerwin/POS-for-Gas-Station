using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;
using System.Windows.Controls;
using System.ComponentModel;

namespace MWS.Users_managment
{
    public class AddEmployeeModelView : ObservableObject, IPageViewModel,  INotifyPropertyChanged, IObserver 
    {
        # region IPageViewModel interface
        private bool edit = false;


        public AddEmployeeModelView(Cashier obj = null)
        {
            if (obj != null)
            {
                _cashier = (Cashier)obj;
                edit = true;
            }
            UpdateModels();
        }
        public AddEmployeeModelView(Observer observer)
        {
            observer.Attach(this);
        }




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
        public List<TypeOfEmployment> EmploymentList { get; set; }
        public TypeOfEmployment _typeOfEmployment { get; set; } = new TypeOfEmployment();
        public List<EmPosition> PositionList { get; set; } 
        public EmPosition _position { get; set; } = new EmPosition();
        public List<Staff> StaffList { get; set; } 
        public Staff _staff { get; set; } = new Staff();

        private void UpdateModels()
        {
            EmploymentList  = UserHandler.GetAllEmploymentTypes();
            PositionList  = UserHandler.GetAllEmployeePostion();
            StaffList  = UserHandler.GetAllStaffType(); 
        }


        public Cashier _cashier { get; set; } = new Cashier()
        {
            Person = new Person()
        };

        public string Login { get; set; } = "Admin";
        public string Password { get; set; } = "Admin";

       
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
                if (edit)
                {
                    try
                    {
                        db.Attach(_cashier);
                        db.ObjectStateManager.ChangeObjectState(_cashier, System.Data.EntityState.Modified);
                        db.SaveChanges();
                        MessageBox.Show("Employee data changed");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check data");
                    }
                }
                else
                {
                    _cashier.Hire_date = DateTime.Now;
                    _cashier.ID_Type_of_employment = _typeOfEmployment.TypeOfEmploymentID;
                    _cashier.IDEmPosition = _position.EmPositionID;
                    _cashier.Id_Staff = _staff.StaffID;
                    try
                    {
                        db.People.AddObject(_cashier.Person);
                        db.SaveChanges();
                        StoredPocedures.AddLoginProc(_cashier.CashierID, Login, Password, out string outResult);
                        if (outResult != "Success")
                        {
                            MessageBox.Show("Please check login or password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please check data");
                    }
                }
            }
        }

        public void Update(ISubject subject)
        {
            UpdateModels();
        }
    }
}
