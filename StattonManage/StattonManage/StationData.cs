
using Gas_station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Microsoft.Ajax.Utilities;
using System.Web.Helpers;
using Newtonsoft.Json;

namespace StattonManage
{
    class StationData
    {
        Station station;

      

        public void serializeData(Station station)
        {
            string json = JsonConvert.SerializeObject(station);

            //write string to file
            System.IO.File.WriteAllText(@"D:\path.txt", json);

        }


        public Station DeserializeData()
        {


            return new Station();

        }



        public StationData()
        {


            station = new Station();


        }




    }
}
