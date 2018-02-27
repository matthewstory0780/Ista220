using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float c;
            

            Console.WriteLine("Enter the 'a' coefficient from a quadratic in standard form: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 'b' coefficient from a quadratic in standard form: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 'c' coefficient from a quadratic in standard form: ");
            c = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine($"The value of x is equal to {-b + Math.Sqrt((b * b - 4 * a * c)) / 2 * a} or {-b - Math.Sqrt((b * b - 4 * a * c)) / 2 * a} ");
            
            
        }
    }
}
