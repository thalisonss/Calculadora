using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.API.Models
{
    public class CoinModel
    {
        string coins = string.Empty;
        public CoinModel() 
        {
            Coins = new QuotationModel();
        }

        [JsonProperty(PropertyName = coins)]
        public QuotationModel Coins { get; set; }
    }
}
