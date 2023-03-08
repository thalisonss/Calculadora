using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Database
{
    internal class CalculadoraDatabase
    {
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
    }
}
