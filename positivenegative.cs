using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class positivenegative
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("enter the value ");
            number=Convert.ToInt32(Console.ReadLine());

            if (number %2==0)
            {
                Console.WriteLine($"give the even number");

            }
            else
            {
                Console.WriteLine($"give the odd number");
            }
        }
    }
}
