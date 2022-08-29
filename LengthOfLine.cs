using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineComparison
{
    internal class LengthOfLine
    {
        public static void CalculateLengthOfLine()
        {
            Console.WriteLine("Enter the value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Result is " + result);


        }

    }
}
