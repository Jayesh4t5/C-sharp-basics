using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class radiuscircle
    {
        static void Main(string[] args)
        {
            double radius;
            double result;
         
            Console.WriteLine("enter the radius");
            radius = Convert.ToInt32(Console.ReadLine());

            result = 3.14 * (radius * radius);

            Console.WriteLine($"give the area of circle {result}");




        }
    }
}
