using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int result = Calculator.Calculator.Add(a, b);

            //String message = String.Format("{0} + {1} = {2}", a, b, result);
            Console.WriteLine("{0} + {1} = {2}", a, b, result);
            Console.ReadLine();


        }
    }
}
