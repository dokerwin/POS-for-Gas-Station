using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS
{
    public class PageCategory: BaseViewModel
    {
        private List<PageSubCategory> pageCategory;

        public PageCategory(string pageCategoryName)
        {
            PageCategoryName = pageCategoryName;
            
        }

        public List<PageSubCategory> PageCategories
        {
            get
            {
                return pageCategory;
            }
            set
            {
                pageCategory = value;
                OnPropertyChanged("PageCategories");
            }
        }

        public string PageCategoryName
        {
            get;
            set;
        }
    }
}
