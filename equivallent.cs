using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class equivallent
    {
        static void Main(string[] args)
        {
            double lenght;
            double result;

            Console.WriteLine($"enter the value of lenght");
            lenght=Convert.ToDouble(Console.ReadLine());

            result = 0.25 * 1.73 * lenght * 2;
            Console.WriteLine($"give the area of equilateral triangle {result}");   
        }
    }
}
