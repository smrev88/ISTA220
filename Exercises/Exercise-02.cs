using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 1);
            Console.WriteLine($" The Sum of ten integers is {sum}");

            Console.WriteLine("\nPart2, average 10 numbers.");
            double avg = AvgTenInts(0, 1);
            char letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}" ) ;

            Console.WriteLine("\nPart 3 , average user predetermined number of scores. ");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 1, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4 , average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average is {avg2} and the letter grade is {letterGrade}");
        }

        private static char ConvertNumericToLetterGrade(double avg)
        {

            if (avg >= 90.0)
                return 'A';
            else if (avg >= 80.0)
                return 'B';
            else if (avg >= 70.0)
                return 'C';
            else if (avg >= 60.0)
                return 'D';
            else 
                return 'F';
        }

        

        private static double AvgAnyInts(double sum4, int count)
        {
            Console.Write("Enter a score.Or -1 to compute average: ");
            string input = Console.ReadLine();      
            sum4 += int.Parse(input);
            if (int.Parse(input) > 0) //recursive call
                return AvgAnyInts(sum4, count + 1);
            else
                return ((sum4 + 1) / count);
                
            

        }

        private static double AvgUnkInts(double sum3, int count, int numScores)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum3 += int.Parse(input);
            if (count < numScores) //recursive call
                return AvgUnkInts(sum3, count + 1, numScores);
            else
                return (sum3/numScores);

        }

         static double AvgTenInts(double sum2, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum2 += int.Parse(input);
            if (count < 10) // recursive call
                return AvgTenInts(sum2, count + 1);
            else
                return (sum2/count);
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10) // recursive call
                return SumTenInts(sum, count + 1);
            else      //end case
               return sum;
        }
    }
}
