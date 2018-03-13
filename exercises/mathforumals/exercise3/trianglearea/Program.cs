using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglearea
{
    class Program
    {
        private static object result;
        private static bool FormatException;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the length of side a of triangle: ");
                double a;
                //convert value a into string
                a = double.Parse(Console.ReadLine());
                if (FormatException)
                {
                    Console.WriteLine("invalid Char, enter a number: ");
                    a = double.Parse(Console.ReadLine());
                }
                if (a <= 0)
                {
                    Console.WriteLine("Enter a positive value for a: ");
                    //convert value a into string
                    a = double.Parse(Console.ReadLine());
                }
                //enter the length of side b
                Console.WriteLine("Enter the length of side b of triangle: ");
                double b;
                //convert value b into string
                b = double.Parse(Console.ReadLine());
                if (FormatException)
                {
                    Console.WriteLine("invalid Char. Enter a number: ");
                    b = double.Parse(Console.ReadLine());
                }
                if (b <= 0)
                {
                    Console.WriteLine("Enter a positive value for b: ");
                    b = double.Parse(Console.ReadLine());
                }
                //ask for length of side c
                Console.WriteLine("Enter the length of side c of triangle: ");
                double c;
                //convert value c into string
                c = double.Parse(Console.ReadLine());
                if (FormatException)
                {
                    Console.WriteLine("invalid Char, enter a number: ");
                    c = double.Parse(Console.ReadLine());
                }
                if (c <= 0)
                {
                    Console.WriteLine("Enter a positive value for c: ");
                    c = double.Parse(Console.ReadLine());
                }
                //assign value for variable p
                //solve equation based on formuala convert string to integer and provide answer
                else
                {
                    double p = ((a + b + c) / 2);
                    double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine($"The area of the triangle is {area}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid Character");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }

        }
    }
}