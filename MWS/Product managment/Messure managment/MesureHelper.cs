using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;

namespace MWS.Product_managment.Messure_managment
{
    public class MesureHelper
    {
        public static ObservableCollection<Type_Product> GetAllMesures()
        {
            using(Gas_stationDb db = new Gas_stationDb())
            {
                return new ObservableCollection<Type_Product>(db.Type_Product?.ToList()); 
            }
        }

        public static bool AddMesure(Type_Product mesure)
        {
            bool result = false;
            try
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    if (CheckMesure(mesure) && CheckDublicate(mesure))
                    {
                        db.Type_Product.AddObject(mesure);
                        db.SaveChanges();
                    }
                }
                result = true;
            }
            catch
            {
                result =  false;
            }
            return result;
        }


        private static bool CheckMesure(Type_Product mesure)
        {
          return mesure.Type1 != null && mesure.Units !=null ?true : false;
        }

        private static bool CheckDublicate(Type_Product mesure)
        {
            bool result = true;
            int exist = 0;
            try
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    exist = db.Type_Product.Where(x=>x.Type1 == mesure.Type1
                    && x.Units == mesure.Units).ToList().Count;
                }
                result = exist > 0 ? false : true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
