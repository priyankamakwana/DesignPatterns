using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class Test
    {
        public static void Main(string[] str)
        {
            string type1 = "Subtract";
            double num1 = 10, num2 = 5;
            CalculateFactory obj2 = new CalculateFactory();
            ICalculate i = obj2.GetCalculation(type1);
            i.calculate(num1, num2);
        }
    }
}
