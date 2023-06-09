using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class greaternuber
    {
        static void Main(string[] args)
        {
            double num_1;
            double num_2;
            double result;

            Console.WriteLine("enter the first number");
            num_1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the second number");
            num_2=Convert.ToDouble(Console.ReadLine());

            if (num_1 > num_2) 
            {
                Console.WriteLine($" the greater number is  {num_1}");
            }
            else
            {
                Console.WriteLine($"the greater number is {num_2}");
            }


        }
    }
}