using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Add : ICalculate
    {
        public void calculate(double a, double b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }
    }
}
