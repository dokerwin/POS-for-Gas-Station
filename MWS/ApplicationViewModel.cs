using MWS.Helper_Classes;
using MWS.MainMenu;
using MWS.Pomotion_management;
using MWS.Product_managment;
using MWS.Product_managment.Category_managment;
using MWS.Product_managment.Developer_managment;
using MWS.Product_managment.Distributor_managment;
using MWS.Users_managment;
using MWS.Users_managment.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using TorasSQLHelper;

namespace MWS
{
    public class ApplicationViewModel : ObservableObject, IObserver
    {
        #region Fields
        private ICommand _changePageCommand;
        private IPageViewModel _currentPageViewModel;
        private List<IPageViewModel> _pagebuttonsViewModels;
        private List<IPageViewModel> _pageViewModels;
        private List<PageCategory> pageCategories;
        public string Name { get; set; } = "Menu";


        public List<PageCategory> _PageCategories
        {
            get
            {
                return pageCategories;
            }
            set
            {
                pageCategories = value;
                OnPropertyChanged("_PageCategories");
            }
        }

        #endregion

        public ApplicationViewModel()
        {
            var UserObserver = new Observer();
            var addEmployeeModelView = new AddEmployeeModelView(UserObserver);
            var addCustomerModelView =  new UsersModelView(UserObserver);
            var allCustomerModelView =  new AllCustomersViewModel(UserObserver);
            var allEmployeesViewModel =  new AllEmployeesViewModel(UserObserver);


            UserObserver.Notify();

            UserObserver.Attach(addEmployeeModelView);
            UserObserver.Attach(addCustomerModelView);
            UserObserver.Attach(allCustomerModelView);
            UserObserver.Attach(allEmployeesViewModel);





            _PageCategories = new List<PageCategory>()
            {
                new PageCategory("Product")
                {
                    PageCategories = new List<PageSubCategory>()
                    {
                        new PageSubCategory("Add product")
                     {
                         Views = new List<IPageViewModel>()
                         {
                           addEmployeeModelView,
                           allEmployeesViewModel,
                           addCustomerModelView,
                           allCustomerModelView,
                          
                         }
                      },
                           new PageSubCategory("Products")
                     {
                         Views = new List<IPageViewModel>()
                         {
                           new ProductManagmentViewModel()
                         }
                      }
                    }
                },
                new PageCategory("Users")
                {
                    PageCategories = new List<PageSubCategory>()
                    {
                      new PageSubCategory("User")
                     {
                         Views = new List<IPageViewModel>()
                         {
                           new UsersModelView(),
                           new AddEmployeeModelView(),
                           new AllCustomersViewModel(),
                           new AllEmployeesViewModel(),
                         }
                      }
                    }
                },

                  new PageCategory("Promotions")
                {
                    PageCategories = new List<PageSubCategory>()
                    {
                      new PageSubCategory("Promo")
                     {
                         Views = new List<IPageViewModel>()
                         {
                           new PromotionManagementViewModel(null),
                           new CategoryPromotionManagementModelView()
                         }
                      }
                    }
                }
            };



            // Set starting page
            // Add available pages
            PageViewModels.Add(new MainViewModel());
            CurrentPageViewModel = PageViewModels[0];


            Mediator.Subscribe("AddEmpoyeeView", AddEmployeeView);
            Mediator.Subscribe("AddEmployeeViewEdit", GoToAddEmployeeViewView);
            Mediator.Subscribe("AddCustomerView", AddCustomerView);
            Mediator.Subscribe("AddCustomerViewEdit", GoToAddCustomerViewEdit);
            Mediator.Subscribe("AllCustomersView", AllCustomersView);
            Mediator.Subscribe("AddProductViewEdit", GoToAddProductView);
            Mediator.Subscribe("AddProductView", GoToAddProductView);
            Mediator.Subscribe("AddCategoryView", GoToAddCategoryView);
            Mediator.Subscribe("DevelopersManagementView", GoToDevelopersManagementView);
            Mediator.Subscribe("DistributorsManagementView", GoToDistributorsManagementView);
            Mediator.Subscribe("AddDeveloperView", GoToAddDeveloperView);
            Mediator.Subscribe("AddDistributorView", GoToAddDistributorView);
            Mediator.Subscribe("AddDeveloperViewEdit", GoToAddDeveloperViewEdit);
            Mediator.Subscribe("AddDistributorViewEdit", GoToAddDistributorViewEdit);
            Mediator.Subscribe("PromotionManagementViewEdit", GoToPromotionManagementViewEdit);


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
            ChangeViewModel(new UsersModelView());
        }

        private void GoToAddCustomerViewEdit(object obj)
        {
            ChangeViewModel(new UsersModelView(obj));
        }

        private void AddEmployeeView(object obj)
        {
            ChangeViewModel(new AddEmployeeModelView());
        }

        private void GoToAddEmployeeViewView(object obj)
        {
            ChangeViewModel(new AddEmployeeModelView((Cashier)obj));
        }


        private void AllCustomersView(object obj)
        {
            ChangeViewModel(new AllCustomersViewModel());
        }
        private void GoToAddProductView(object obj)
        {
            ChangeViewModel(new AddProductModelView(obj));
        }

        private void GoToAddProductViewEdit(object obj)
        {
            ChangeViewModel(new AddProductModelView(obj, true));
        }

        private void GoToAddCategoryView(object obj)
        {
            ChangeViewModel(new AddCategoryModelView(obj));
        }

        private void GoToAddDeveloperView(object obj)
        {
            ChangeViewModel(new AddDeveloperViewModel(obj));
        }

        private void GoToAddDistributorView(object obj)
        {
            ChangeViewModel(new AddDistributorViewModel(obj));
        }

        private void GoToDevelopersManagementView(object obj)
        {
            ChangeViewModel(new DevelopersManagmentViewModel(obj));
        }


        private void GoToAddDistributorViewEdit(object obj)
        {
            ChangeViewModel(new AddDistributorViewModel(obj, true));
        }

        private void GoToAddDeveloperViewEdit(object obj)
        {
            ChangeViewModel(new AddDeveloperViewModel(obj, true));
        }

        private void GoToDistributorsManagementView(object obj)
        {
            ChangeViewModel(new DistributorsManagementViewModel(obj));
        }

        #endregion
        private void GoToPromotionManagementViewEdit(object obj = null)
        {
            ChangeViewModel(new PromotionManagementViewModel(obj));
        }

        public void Update(ISubject subject)
        {
            throw new NotImplementedException();
        }

        public ICollectionView Navigation
        {
            get
            {
                var source = CollectionViewSource.GetDefaultView(this._pagebuttonsViewModels);
                source.GroupDescriptions.Add(new PropertyGroupDescription("Type")
            );
                return source;
            }
        }
    }
}
