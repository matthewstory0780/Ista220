﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating");
        }
        public void brake()
        {
            Console.WriteLine($"Braking");
        }
        public override void Drive()
        {
            Console.WriteLine($"SHAKE and BAKE");
        }
    }
}
