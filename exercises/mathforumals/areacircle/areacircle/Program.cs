using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areacircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //assign value to radius (r)
            double r;

            //assign value for pi (3.14159)
            double pi = 3.14;

            //ask for radius of circle
            Console.WriteLine("Enter the radius of the circle: ");

            //convert radius integer into string
            r = Convert.ToDouble(Console.ReadLine());

            //give area of circle
            Console.WriteLine($"Area of cicle {r * r * pi} ");

            //give circumference of circle
            Console.WriteLine($"Circumference of circle {pi * 2 * r} ");
            
        }
    }
}
