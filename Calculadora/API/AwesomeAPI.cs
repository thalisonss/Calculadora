using Calculadora.API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.API
{
    internal class AwesomeAPI
    {
        public string ConsultQuotation(string firstCoin, string secondCoin)
        {
            string strURL = $"https://economia.awesomeapi.com.br/last/{firstCoin}{"-"}{secondCoin}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(strURL).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    CoinModel model = JsonConvert.DeserializeObject<CoinModel>(result);                                 

                    if (firstCoin == "BRL" &&  secondCoin == "USD")
                    {
                        return model.BRLUSD.Bid;
                    }
                    else if (firstCoin == "BRL" && secondCoin == "EUR")
                    {
                        return model.BRLEUR.Bid;
                    }
                    else if (firstCoin == "USD" && secondCoin == "BRL")
                    {
                        return model.USDBRL.Bid;
                    }
                    else if (firstCoin == "USD" && secondCoin == "EUR")
                    {
                        return model.USDEUR.Bid;
                    }
                    else if (firstCoin == "EUR" && secondCoin == "BRL")
                    {
                        return model.EURBRL.Bid;
                    }
                    else if (firstCoin == "EUR" && secondCoin == "USD")
                    {
                        return model.EURUSD.Bid;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }              
            }

        }

    }
}
