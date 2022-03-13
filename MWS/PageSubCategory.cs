using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS
{
    public class PageSubCategory: BaseViewModel
    {
        private List<IPageViewModel> views;

        public PageSubCategory(string pageSubCategoryName)
        {
            PageSubCategoryName = pageSubCategoryName;

        }
        public List<IPageViewModel> Views
        {
            get
            {
                return views;
            }
            set
            {
                views = value;
                OnPropertyChanged("Views");
            }
        }

        public string PageSubCategoryName
        {
            get;
            set;
        }
    }
}
