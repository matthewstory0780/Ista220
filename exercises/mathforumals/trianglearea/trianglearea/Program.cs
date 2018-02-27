using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglearea
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variable value for a
            float a;

            //create variable value for b
            float b;

            //create varible value for c
            float c;

            //ask for length of side a
            Console.WriteLine("Enter the length of side a of triangle: ");

            //convert value a into string
            a = Convert.ToInt32(Console.ReadLine());

            //enter the length of side b
            Console.WriteLine("Enter the length of side b of triangle: ");

            //convert value b into string
            b = Convert.ToInt32(Console.ReadLine());

            //ask for length of side c
            Console.WriteLine("Enter the length of side c of triangle: ");

            //convert value c into string
            c = Convert.ToInt32(Console.ReadLine());

            //assign value for variable p
            double p = ((a + b + c) / 2);

            //solve equation based on formuala convert string to integer and provide answer
           Console.WriteLine($"The area of the triangle is {Math.Sqrt(p * (p - a) * (p - b) * (p - c))}" );

        }
    }
}