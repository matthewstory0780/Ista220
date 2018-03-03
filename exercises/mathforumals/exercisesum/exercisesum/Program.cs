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
            Console.WriteLine("Sum ten numbers.");
            int sum = 0;
            int count = 0;

            //call a function
            get_sums();

            //inform user
            Console.WriteLine($"The sum is {sum}" );

            void get_sums()
            {
                count++;
                Console.WriteLine($"Enter integer {count}: " );
                sum += int.Parse(Console.ReadLine());
                if (count < 10)
                    get_sums();
                else
                    return;

            }

        }
    }
}