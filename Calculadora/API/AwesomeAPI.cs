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
            string strURL = "https://economia.awesomeapi.com.br/last/" + firstCoin + "-" + secondCoin;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.GetAsync(strURL).Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    CoinModel model = JsonConvert.DeserializeObject<CoinModel>(result);

                    string compra = model.BRLUSD.Bid;

                    return compra;
                }
                else
                {
                    return null;
                }              
            }

        }

    }
}
