using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RDISoftware
{
    [ApiController]
    [Route("api1/[Controller]")]
    public class CostumerController : ControllerBase
    {
        private static List<CostumersReturn> costumer = new List<CostumersReturn>();

        private static List<CostumersData> costumerData = new List<CostumersData>();

        [HttpGet]
        public List<CostumersReturn> ReceiveCostumersReturn(DateTime registrationDate, long token, int cardId)
        {            
            costumer.Add(new CostumersReturn(registrationDate, token, cardId)); 
            return costumer;            
        }

        [HttpPost]
        public void SaveCostumersCard(int costumerId, long cardNumber, int cvv)
        {
            costumerData.Add(new CostumersData(costumerId, cardNumber, cvv));
            if(costumerData != null)
            {
                string lastCardNumbers = cardNumber.ToString();
                lastCardNumbers = lastCardNumbers.Substring(lastCardNumbers.Length -4);
            }
            
        }

    }


}