namespace LineComparison
{
    internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number\n 1.Length of Line\n 2.Equality of Line\n 3.Compare the length\n 4. Line Comparison Using Oops Concept");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        LengthOfLine.CalculateLengthOfLine();
                    break;
                    case 2:
                        EqualityOfLine.CalculateLength();
                    break;
                    case 3:
                        Compare2Line.CompareLength();
                    break ;
                case 4:
                    Console.WriteLine(UsingOopConcept.CompareTwoLines());
                    Compare compare = new Compare();
                    compare.CompareTwoLines();
                    break;
                default:
                        Console.WriteLine("Entered Wrong Number");
                    break;
                }
            }
        }
    }
    