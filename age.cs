using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class age
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter the age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"eligible for voting ");

            }
            else
            {

                Console.WriteLine($"not eligible for voting");
            }
        }
    }
}
