using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, circumference and area of a circle.");
            Console.WriteLine("Enter an integer for the radius: ");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * (Math.PI * intradius);
            Console.WriteLine($" The circumference is {circumference}");
            double area = Math.PI * Math.Pow(intradius, 2);
            Console.WriteLine($" The area is {area}");

            Console.WriteLine("\nPart2, volume of a hemisphere.");
            double volume = ((double)4 / 3 * Math.PI * (Math.Pow(intradius, 3)/(double)2));
            Console.WriteLine($"The volume is {volume }");

            Console.WriteLine("\nPart3, area of  a triangle (Heron's formula).");
            Console.WriteLine(" Enter an integer for side A");
            string strSideA = Console.ReadLine();
            int intSideA = int.Parse(strSideA);
            Console.WriteLine(" Enter an integer for side B");
            string strSideB = Console.ReadLine();
            int intSideB = int.Parse(strSideB);
            Console.WriteLine(" Enter an integer for side C");
            string strSideC = Console.ReadLine();
            int intSideC = int.Parse(strSideC);
            double p = (intSideA + intSideB + intSideC) / (double)2;
            double areaTriangle = Math.Sqrt(p * (p - intSideA) * (p - intSideB) * (p - intSideC));
            Console.WriteLine($"The area of the triangle is {areaTriangle}");

            Console.WriteLine("\nPart4, solving a quadratic equation.");
            Console.WriteLine("Enter a value for coefficient A");
            string strcoA = Console.ReadLine();
            int intcoA = int.Parse(strcoA);
            Console.WriteLine("Enter a value for coefficient B");
            string strcoB = Console.ReadLine();
            int intcoB = int.Parse(strcoB);
            Console.WriteLine("Enter a value for coefficient C");
            string strcoC = Console.ReadLine();
            int intcoC = int.Parse(strcoC);
            double possolution = ((double)intcoB * (-1) + Math.Sqrt(Math.Pow(intcoB, 2) - (4 * intcoA * intcoC))) / (2 * intcoA);
            double negsolutions = ((double)intcoB * (-1) - Math.Sqrt(Math.Pow(intcoB, 2) - (4 * intcoA * intcoC))) / (2 * intcoA);
            Console.WriteLine($" The positive solution is {possolution}");
            Console.WriteLine($" The negative solution is {negsolutions}");

        }
    }
}
