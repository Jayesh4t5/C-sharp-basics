using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class celcius
    {
        static void Main(string[] args)
        {
            double celcius;
            double result;

            Console.WriteLine("enter the temperaature in celcius");
            celcius = Convert.ToDouble(Console.ReadLine());

            result = (celcius * 9 / 5) + 32;

            Console.WriteLine($"give the temprature in fahrenheit {result}");
        }
    }
}
