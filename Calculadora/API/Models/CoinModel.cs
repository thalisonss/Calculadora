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
            EURBRL = new QuotationModel();
            BRLEUR = new QuotationModel();
            EURUSD = new QuotationModel();
            USDEUR = new QuotationModel();
        }

        [JsonProperty(PropertyName = "BRLUSD")]
        public QuotationModel BRLUSD { get; set; }

        [JsonProperty(PropertyName = "BRLEUR")]
        public QuotationModel BRLEUR { get; set; }

        [JsonProperty(PropertyName = "USDBRL")]
        public QuotationModel USDBRL { get; set; }

        [JsonProperty(PropertyName = "USDEUR")]
        public QuotationModel USDEUR { get; set; }

        [JsonProperty(PropertyName = "EURBRL")]
        public QuotationModel EURBRL { get; set; }

        [JsonProperty(PropertyName = "EURUSD")]
        public QuotationModel EURUSD { get; set; }
    }
}
