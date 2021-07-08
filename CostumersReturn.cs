using System;

namespace RDISoftware
{
    public class CostumersReturn
    {
        public DateTime RegistrationDate { get; set; }
        public long Token { get; set; }
        public int CardId { get; set; }       

        public CostumersReturn(DateTime registrationDate, long token, int cardId)
        {
            registrationDate = DateTime.Now;
            RegistrationDate = registrationDate;
            Token = token;
            cardId = 1;
            CardId = cardId;
            
        }
    }
}
