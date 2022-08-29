namespace Day3LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison");
            Console.WriteLine("Enter Number\n 1.Length of Line\n 2.Equality of Line\n 3.Compare the length");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    LengthOfLine.CalculateLengthOfLine();
                    break;
                case 2:
                    EqualityOfLines.CalculateLength();
                    break;
                case 3:
                    Compare2Line.CompareLength();
                    break;
                default:
                    Console.WriteLine("Entered Wrong Number");
                    break;
            }
        }


        }
}
