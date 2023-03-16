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
        public CoinModel() 
        {
            BRLUSD = new QuotationModel();
            USDBRL = new QuotationModel();
        }

        [JsonProperty(PropertyName = "BRLUSD")]
        public QuotationModel BRLUSD { get; set; }

        [JsonProperty(PropertyName = "USDBRL")]
        public QuotationModel USDBRL { get; set; }
    }
}
