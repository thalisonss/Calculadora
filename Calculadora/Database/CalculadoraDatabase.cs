using Calculadora.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Database
{
    internal class CalculadoraDatabase
    {
        AwesomeAPI api = new AwesomeAPI();
        public decimal Calculate(decimal firstValue, decimal secondValue, string operation)
        {
            decimal total = 0;

            if (operation == "+")
            {
                total = firstValue + secondValue;
                return total;
            }
            if (operation == "-")
            {
                total = firstValue - secondValue;
                return total;
            }
            if (operation == "*")
            {
                total = firstValue * secondValue;
                return total;
            }
            if(operation == "/")
            {
                total = firstValue / secondValue;
                return total;
            }
            else
            {
                return total;
            }

        }

        public string PutNegativeValuePositive(decimal value)
        {
            decimal result = value - (value * 2);

            return result.ToString();
        }

        public string CurrencyRate(string secondCurrencySymbol, string firstCurrencySymbol)
        {
            string taxa = api.ConsultQuotation(secondCurrencySymbol, firstCurrencySymbol);

            return taxa.Replace(".", ",");
        }
    }
}
