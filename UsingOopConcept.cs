using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UsingOopConcept
    {
        public static double CompareTwoLines()
        {
            int x1 = 12, y1 = 13, x2 = 43, y2 = 15;

            double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

            return length1;
        }
    }
    public class Compare : UsingOopConcept
    {
        double length1 = UsingOopConcept.CompareTwoLines();
        public void CompareTwoLines()
        {
            int m1 = 1, n1 = 3, m2 = 6, n2 = 9;


            double length2 = Math.Sqrt((m2 - m1) ^ 2 + (n2 - n1) ^ 2);
            double result = length1.CompareTo(length2);
            if (result > 0)
                Console.WriteLine("Line 1 is greater ");
            else if (result < 0)
                Console.WriteLine("Line 2 is greater");
            else
                Console.WriteLine("Lines are equal");
        }

    }

}
