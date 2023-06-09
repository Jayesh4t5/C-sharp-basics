using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class fahrenite
    {
        static void Main(string[] args)
        {
            double fahrenite;
            double result;

            Console.WriteLine("enter the temperaature in fahrenite");
            fahrenite = Convert.ToDouble(Console.ReadLine());

            result = (.05555 * (fahrenite - 32));

            Console.WriteLine($"give the temprature in celcius {result}");
        }
    }
}
