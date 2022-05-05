using MWS.Helper_Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MWS.MWSUtil.Enums;
using TorasSQLHelper;

namespace MWS.Shift_managment
{
    public class ShiftManagmentViewModel : ObservableObject, IPageViewModel
    {

        public ObservableCollection<Shift> shifts { get; set; } = new ObservableCollection<Shift>();

        public Shift actualsift { get; set; } = new Shift();

        public DateTime ShiftToSearchByDate = DateTime.MinValue;

        #region IComand buttons

        private ICommand findShiftButton { get; set; }
        private ICommand buttonDetails { get; set; }
        private ICommand forceShiftEndButton { get; set; }


        #endregion

        #region IComand public methods buttons

        public ICommand ButtonDetails
        {
            get
            {
                return buttonDetails;
            }
            set
            {
                buttonDetails = value;
            }
        }

        public ICommand ForceShiftEndButton
        {
            get
            {
                return forceShiftEndButton;
            }
            set
            {
                forceShiftEndButton = value;
            }
        }

       
        public ICommand FindShiftButton
        {
            get
            {
                return findShiftButton;
            }
            set
            {
                findShiftButton = value;
            }
        }
        #endregion

        public ShiftManagmentViewModel()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                foreach (var shift in db.Shifts.Include("Cashier").Include("Person").ToList())
                {
                    shifts.Add(shift);
                }
                actualsift = db.Shifts.LastOrDefault();
            }

            findShiftButton = new RelayCommand(FindShift);
            forceShiftEndButton = new RelayCommand(ForceShiftEnd);
            buttonDetails = new RelayCommand(ShowDetails);
        }

        public void FindShift(object obj)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                shifts = new ObservableCollection<Shift>(db.Shifts.Where(
                shift => shift.Shift_start== ShiftToSearchByDate).ToList());
            }
        }

        public void ShowDetails(object obj)
        {
            Mediator.Notify("ShiftDetailsView", obj);
        }

        public void ForceShiftEnd(object obj)
        {
            var item = obj as Shift;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    item.Shift_end = DateTime.Now;
                //    db.Entry(item).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            Mediator.Notify("ShiftDetailsView", null);
        }










        #region IPageViewModel interface

        public string Name
        {
            get { return "Products managements"; }
        }

        public string ButtonPage
        {
            get { return "Assets/person.png"; }
        }

        public PageType TypeOfPage
        {
            get { return PageType.ShiftManagement; }
        }
        #endregion
    }
}
