using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumehemisphere2
{
    class Program
    {
        static void Main(string[] args)
        {
            //asign value to radius (r)
            double r;

            //asign value 3.14159 for pi
            double pi = 3.14159;

            //ask for length of radius
            Console.WriteLine("input the radius of the circle: ");

            //convert radius integer into string
            r = Convert.ToDouble(Console.ReadLine());

            //give volume of hemisphere calculated using formula
            Console.WriteLine($"volume of hemisphere {(r * r * r) * pi * 2 / 3}");
            Console.Read();

        }
    }
}
