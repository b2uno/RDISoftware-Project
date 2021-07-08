using System;

namespace RDISoftware
{
    public class CostumersData 
    {
        public int CostumerId { get; set; }
        public long CardNumber { get; set; }
        public int CVV { get; set; }

        public CostumersData(int costumerId, long cardNumber, int cvv)
        {
            this.CostumerId = costumerId;
            this.CardNumber = cardNumber;
            this.CVV = cvv;
           
        }
    }
}
