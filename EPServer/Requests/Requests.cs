using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPServer.Requests
{
    public class Card
    {
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardCircuit { get; set; }
    }

    public class Total
    {
        public string Currency { get; set; }
        public string Amount { get; set; }
    }

    public class CardServiceResponse
    {
        public string OverallResult { get; set; }
        public string RequestID { get; set; }
        public string RequestType { get; set; }
        public Card card { get; set; }
        public Total total { get; set; }
    }
}
