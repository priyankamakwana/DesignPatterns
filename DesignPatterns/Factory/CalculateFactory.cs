using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;
            if (type.ToLower().Equals("add"))
                obj = new Add();
            else if (type.ToLower().Equals("subtract"))
                obj = new Subtract();
            else if (type.ToLower().Equals("divide"))
                obj = new Divide();
            else
                Console.WriteLine("Invalid type");
            return obj;
        }
    }
}
