using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Product_managment.Developer_managment
{
    internal class DeveloperHandler
    {
        public static ObservableCollection<Developer> GetAllDeveloperList()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Developer>(db.Developers.Include("Company"));
            }
        } 
    }
}
