using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class thirdangle
    {
        static void Main(string[] args)
        {
            double angle_1;
            double angle_2;
            double result;

            Console.WriteLine("enter the value of angle 1");
            angle_1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the value of angle 2");
            angle_2=Convert.ToDouble(Console.ReadLine());

            result = 180-(angle_1+angle_2);

            Console.WriteLine($" give the value of third angle {result}");


        }
    }
}
