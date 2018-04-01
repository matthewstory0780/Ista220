using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sqaud_Leader : leader
    {
        public override void Type()
        {
            Console.WriteLine($"I am a Squad Leader, I lead a 9 Man Sqaud");
        }
    }
    class Platoon_SGT : leader
    {
        public override void Type()
        {
            Console.WriteLine($"I am a Platoon sgt, I lead a platoon");
        }
    }
    class First_SGT : leader
    {
        public override void Type()
        {
            Console.WriteLine($"I am a First Sgt, I execute the CO's orders");
        }
    }
    class Platoon_Leader : leader
    {
        public override void Type()
        {
            Console.WriteLine($"I am a Platoon Leader, I help the Platoon Sgt");
        }
    }
    class Commanding_Officer : leader
    {
        public override void Type()
        {
            Console.WriteLine($"I am the Commanding Officer, I lead the company");
        }
    }
}
