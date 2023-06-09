using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class evenodd
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter the value ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine($"number is positive");
            }
            else
            {
                Console.WriteLine($"number is negative");
            }




        }
    }
}
