using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorasSQLHelper;
namespace MWS.Users_managment.Loyalty_managment
{
    public class LoyaltyHandler
    {

        public static LoyaltyCard GetNewLoyaltyCardByDefault()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return new LoyaltyCard()
                {
                    Balance = 0,
                    ID_MOP = db.MOPs.FirstOrDefault(c => c.Mop_Type == "DebitCard").MopID 
                };
            }
        }


        public static decimal GetLoyaltyCardBalance(Customer customer)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Customers.FirstOrDefault(c => c.ID_LoyaltyCard == customer.ID_LoyaltyCard).LoyaltyCard.Balance;
            }
        }

        public static decimal GetLoyaltyCardBalance(int IdCustonner)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Customers.FirstOrDefault(c => c.ID_LoyaltyCard == IdCustonner).LoyaltyCard.Balance;
            }
        }




    }
}
