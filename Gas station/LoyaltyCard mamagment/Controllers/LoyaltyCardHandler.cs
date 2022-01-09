using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.LoyaltyCard_mamagment
{
    public class LoyaltyCardHandler
    {

        private LoyaltyCard loyaltyCard { get; set; }
        public decimal getBalance(int card)
        {
            if (findLoyalitycard(card))
            {
                return (decimal)loyaltyCard.Amount;
            }
            else
            {
                return 0m;
            }
        }

        public bool findLoyalitycard(int CardNumner)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                loyaltyCard = db.LoyaltyCards.FirstOrDefault(m => m.LoyaltyCardID == CardNumner);

                if (loyaltyCard != null) return true;
            }
            loyaltyCard = null;
            return false;
        }

        public void TopUpCard(decimal sum)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var a = db.LoyaltyCards.FirstOrDefault(m => m.LoyaltyCardID == loyaltyCard.LoyaltyCardID);
                a.Amount = sum;
                db.SaveChanges();
            }
        }
    }
}
