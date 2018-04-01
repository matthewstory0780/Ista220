using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team_Leader : soldier
    {
        public override void Role()
        {
            Console.WriteLine($"I am a Team Leader, I lead a 4 man fire team");
        }
        public override void Ammo()
        {
            Console.WriteLine($"I carry 210 rounds off 5.56 ammunition");
        }
    }
    class Rifleman : soldier
    {
        public override void Role()
        {
            Console.WriteLine($"I am a Rifleman, I carry extra equipment");
        }
        public override void Ammo()
        {
            Console.WriteLine($"I carry 210 rounds off 5.56 ammunition");
        }
    }
    class Automatic_Rifleman : soldier
    {
        public override void Role()
        {
            Console.WriteLine($"I am an Automatic Rifleman, I carry the M249 and use it to supress the enemy");
        }
        public override void Ammo()
        {
            Console.WriteLine($"I carry 1000 rounds off 5.56 ammunition");
        }
    }
    class Grenadier : soldier
    {
        public override void Role()
        {
            Console.WriteLine($"I am a Grenadier, I carry the 320 and use it to clear bunkers and buildings");
        }
        public override void Ammo()
        {
            Console.WriteLine($"I carry 15 40mm grenades");
        }
    }
    class bad_rifleman : soldier
    {
        public override void Role()
        {
            Console.WriteLine($"I a-am... A Rifleman, I..uhhh..um I dont know, Sergeant");
        }
        public override void Ammo()
        {
            Console.WriteLine($"I c-carry... Uhh.. Im not sure Sergeant");
        }
    }

}

