using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class avg_percentage
    {
        static void Main(string[] args)
        {
            double sub1;
            double sub2;
            double sub3;
            double sub4;
            double sub5;
            double average;
            double percentage;

            Console.WriteLine("enter the marks of 1st sub");
            sub1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the marks of 2nd subject");
            sub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the marks of 3rd  subject");
            sub3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the marks of 4th subject");
            sub4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the marks of 5th subject");
            sub5 = Convert.ToDouble(Console.ReadLine());

            percentage = ((sub1 + sub2 + sub3 + sub4 + sub5) / 500) * 100;

            average = (sub1 + sub2 + sub3 + sub4 + sub5) / 5;

            Console.WriteLine($"give the percentage of {percentage}");
            Console.WriteLine($"give the average of five subjects {average}");
        }
    }
}
