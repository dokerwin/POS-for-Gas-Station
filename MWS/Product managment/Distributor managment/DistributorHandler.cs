using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;

namespace MWS.Product_managment.Distributor_managment
{
    internal class DistributorHandler
    {
        public static ObservableCollection<Distributor> GetAllDsitributorList()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Distributor>(db.Distributors.Include("Company"));
            }
        }
    }
}
