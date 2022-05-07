using MWS.Helper_Classes;
using MWS.MWSUtil;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TorasSQLHelper;

namespace MWS.Product_managment.Messure_managment.ViewModels
{
    public class AddMesureViewModel : ObservableObject, IObserver, IPageViewModel
    {
        #region Public members

        public Type_Product Type_Product
        {
            get 
            {
                if (_type_Product is null)
                {
                    _type_Product = new Type_Product();
                }
                return _type_Product;
            }
            set
            {
                _type_Product = value;
                RaisePropertyChanged(nameof(Type_Product));
            }
        }
        public ObservableCollection<Type_Product> mesures { get; set; } = new ObservableCollection<Type_Product>();

        #endregion

        #region ICommand public members
        public ICommand AddMesureButton
        {
            get
            {
                if (_addEmployeeButton == null)
                {
                    _addEmployeeButton = new RelayCommand(SaveMesure);
                }
                return _addEmployeeButton;
            }
        }

        public ICommand ButtonEdit
        {
            get
            {
                if (_buttonEdit is null)
                {
                    _buttonEdit = new RelayCommand(EditMesure);
                }
                return _buttonEdit;
            }
        }

        public ICommand ButtonDelete
        {
            get
            {
                if (_buttonEdit is null)
                {
                    _buttonEdit = new RelayCommand(DeleteMesure);
                }
                return _buttonEdit;
            }
        }

        #endregion

        #region Constructor/Destructors

        public AddMesureViewModel(Observer observer)
        {
            _observer = observer;
        }

        #endregion

        #region Private Methods

        private void SaveMesure(object obj)
        {
    

        }
        private void DeleteMesure(object obj)
        {
            throw new NotImplementedException();
        }

        private void EditMesure(object obj)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Private members 

        private Observer _observer = null;
        private Type_Product _type_Product = null;

        #endregion

        #region ICommand private members

        private ICommand _addEmployeeButton { get; set; }
        private ICommand _buttonDelete { get; set; }
        private ICommand _buttonEdit { get; set; }

        #endregion

        #region IPageViewModel interface
        public string Name => throw new NotImplementedException();

        public string ButtonPage => throw new NotImplementedException();

        public Enums.PageType TypeOfPage => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region IObserver interfface impementation

        public void Update(ISubject subject)
        {
           
        }

        #endregion
    }

}
