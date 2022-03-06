using MWS.Helper_Classes;
using MWS.MainMenu;
using MWS.Product_managment;
using MWS.Product_managment.Category_managment;
using MWS.Users_managment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWS
{
    public class ApplicationViewModel : ObservableObject
    {
        #region Fields

        private ICommand _changePageCommand;


        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pagebuttonsViewModels;
        private List<IPageViewModel> _pageViewModels;

        #endregion

        public ApplicationViewModel()
        {
            // Add available pages
            PageViewModels.Add(new MainViewModel());
            PageViewModels.Add(new AddEmployeeModelView());
            PageViewModels.Add(new AddProductModelView());
            PageViewModels.Add(new ProductManagmentViewModel());
            PageViewModels.Add(new UsersModelView());
            PageViewModels.Add(new AddEmployeeModelView());
            PageViewModels.Add(new EmployeeManagmentViewModel());
            PageViewModels.Add(new AddCateforyModelView());
            PageViewModels.Add(new AllCustomersViewModel());

            //Add page to button 
            PageButtonsViewModels.Add(new MainViewModel());
            PageButtonsViewModels.Add(new EmployeeManagmentViewModel());
            PageButtonsViewModels.Add(new ProductManagmentViewModel ());

            PageButtonsViewModels.Add(new AddCateforyModelView());


            // Set starting page
            CurrentPageViewModel = PageViewModels[0];

            Mediator.Subscribe("AddEmpoyeeView", AddEmployeeView);
            Mediator.Subscribe("AddCustomerView", AddCustomerView);
            Mediator.Subscribe("AllCustomersView", AllCustomersView);
            Mediator.Subscribe("AddProductView", GoToAddProductView);
            Mediator.Subscribe("AddCategoryView", GoToAddCategoryView);
        }
        #region Properties / Commands

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => ChangeViewModel((IPageViewModel)p),
                        p => p is IPageViewModel);
                }

                return _changePageCommand;
            }
        }
        public List<IPageViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IPageViewModel>();

                return _pageViewModels;
            }
        }
        public List<IPageViewModel> PageButtonsViewModels
        {
            get
            {
                if (_pagebuttonsViewModels == null)
                    _pagebuttonsViewModels = new List<IPageViewModel>();

                return _pagebuttonsViewModels;
            }
        }
        public IPageViewModel CurrentPageViewModel
        {
            get
            {
                return _currentPageViewModel;
            }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        #endregion

        #region Methods

        private void ChangeViewModel(IPageViewModel viewModel)
        {
            if (!PageButtonsViewModels.Contains(viewModel))
                 PageButtonsViewModels.Add(viewModel);

            CurrentPageViewModel = PageButtonsViewModels
                .FirstOrDefault(vm => vm == viewModel);
        }

        #endregion

        #region Methods
        private void AddCustomerView(object obj)
        {
            ChangeViewModel(PageViewModels[4]);
        }

        private void AddEmployeeView(object obj)
        {
            ChangeViewModel(PageViewModels[5]);
        }

        private void AllCustomersView(object obj)
        {
            ChangeViewModel(PageViewModels[8]);
        }
        private void GoToAddProductView(object obj)
        {
            PageViewModels[2] = new AddProductModelView(obj, true);
            ChangeViewModel(PageViewModels[2]);
        }
        private void GoToAddCategoryView(object obj)
        {
            PageViewModels[7] = new AddCateforyModelView(obj);
            ChangeViewModel(PageViewModels[7]);
        }


        
        #endregion









    }
}
