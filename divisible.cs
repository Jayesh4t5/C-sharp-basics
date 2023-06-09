using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class divisible
    {
        static void Main(string[] args)
        {
            int num1;
            int result;

            Console.WriteLine("enter the number");
            num1=Convert.ToInt32(Console.ReadLine());

            if (( num1 % 5==0) && (num1%10==0))
            {
                Console.WriteLine($"number is divisible by 5 and 11");

            
            }
            else
            {
                Console.WriteLine($"number is not divisible by 5 and 11");
            }
        }
    }
}
