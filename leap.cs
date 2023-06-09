using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarnary
{
    internal class leap
    {
        static void Main(string[] args)
        {
            int year;
            int result;

            Console.WriteLine("enter the year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0) 
            {
                Console.WriteLine($" this year is leap year ");
            }
            else
            {
                Console.WriteLine($" this year is not leap year ");
            }
        }
       
     
    }
}
