using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class compoundinterest
    {
        static void Main(string[] args)
        {
            double p, t, r ,n;
            double result;

            Console.WriteLine("enter the value of p");
            p=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of t");
            t=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of r");
            r=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("value of n");
            n=Convert.ToDouble(Console.ReadLine());

            result = p * Math.Pow((1 + r / n), n * t);
            Console.WriteLine($" the result is {result}");

            Console.WriteLine("end of the program");




        }
    }
}
