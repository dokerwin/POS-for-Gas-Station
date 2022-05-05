using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TorasSQLHelper;

namespace MWS.Product_managment.MOP_managment
{
    public class MopHandler
    {



        public static List<MOP> GetListMOPs()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.MOPs.ToList();
            }
        }

    }
}
