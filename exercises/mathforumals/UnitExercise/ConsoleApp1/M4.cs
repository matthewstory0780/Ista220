using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class M4 : Weapon
    {
     
        public override void Range()
        {
            Console.WriteLine($"The maximum effective range for my M4 is " +
                $"point target: 500 meters" +
                $"area targets: 800 meters");
        }
    }
    class M249 : Weapon
    {
        public override void RateOfFire()
        {
            Console.WriteLine($"The rates of fire for my M249 are:" +
                $" sustained rate: 100 rounds per minute" +
                $" rapid rate: 200 rounds per minute" +
                $" cyclic rate: 650 to 850 rounds per minute");
        }
        public override void Range()
        {
            Console.WriteLine($"The maximum effective range for my M4 is:  " +
                 $" point target: 600 meters(bipod) 800 meters(tripod)" +
                 $" area targets: 800 meters(bipod) 1000meters (tripod)");
        }
    }
    class M320 : Weapon
    {
        public override void RateOfFire()
        {
            Console.WriteLine($"The rate of fire for my 320 is 5 to 7 round per minute");
        }
        public override void Range()
        {
            Console.WriteLine($"The maximum effective range for my 320 is: " +
                $" point target: 150 meters" +
                $" area target: 350 meters"); 

        }
    }
}
