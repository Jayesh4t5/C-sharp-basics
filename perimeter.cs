using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class perimeter
    {
        static void Main(string[] args)
        {
            double lenght;
            double breadth;
            double result;

            Console.WriteLine("enter the value of lenght");
            lenght=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of bredth");
            breadth=Convert.ToDouble(Console.ReadLine());

            result = (lenght + breadth) * 2;
            Console.WriteLine($"give the perimeter of rectangle {result} ");

        }
    }
}
