using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Weapon
    {
        public virtual void RateOfFire()
        {
            Console.WriteLine($"default implementation of the RateOfFire method");
        }
        public virtual void Range()
        {
            Console.WriteLine($"default implementation of the Range method");
        }
    }
    class program
    {
        static void dowork()
        {
            Console.WriteLine($"Im Captain Crunch");
            Commanding_Officer captain = new Commanding_Officer();
            captain.Type();

            Console.WriteLine($"Im First Sgt Scary");
            First_SGT my1sgt = new First_SGT();
            my1sgt.Type();

            Console.WriteLine($"Im 1LT West Point");
            Platoon_Leader LT = new Platoon_Leader();
            LT.Type();

            Console.WriteLine($"Im SFC Crusty");
            Platoon_SGT crusty = new Platoon_SGT();
            crusty.Type();

            Console.WriteLine($"Im SSG Too Many Kids");
            Sqaud_Leader SSG = new Sqaud_Leader();
            SSG.Type();

            Console.WriteLine($"Im SGT Middleman");
            Team_Leader SGT = new Team_Leader();
            SGT.Role();
            M4 cleanM4 = new M4();
            cleanM4.RateOfFire();
            cleanM4.Range();
            SGT.Ammo();

            Console.WriteLine($"Im SPC Shammer, I have to head to an appointment right after this S'arnt");
            Automatic_Rifleman SPC = new Automatic_Rifleman();
            SPC.Role();
            M249 myM249 = new M249();
            myM249.RateOfFire();
            myM249.Range();
            SPC.Ammo();

            Console.WriteLine("Im PFC Pessimist, this exercise is so stupid!");
            Grenadier PFC = new Grenadier();
            PFC.Role();
            M4 dirtyM4 = new M4();
            dirtyM4.RateOfFire();
            dirtyM4.Range();
            M320 my320 = new M320();
            my320.RateOfFire();
            my320.Range();
            Rifleman newrifle = new Rifleman();
            newrifle.Ammo();

            Console.WriteLine($"I-Im PVT Scared");
            bad_rifleman PVT = new bad_rifleman();
            PVT.Role();
            M4 filthy = new M4();
            filthy.RateOfFire();
            filthy.Range();
            PVT.Ammo();
        }
            
        
    

        static void Main()
        {
            try
            {
                dowork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }

    }
        class soldier
        {
            public virtual void Role()
            {
                Console.WriteLine($"default implementation of the Role method");
            }

            public virtual void Ammo()
            {
                Console.WriteLine($"default implementation of the SpecialTeams method");
            }

        }
        class leader
        {
            public virtual void Type()
            {
                Console.WriteLine($"default implementation of the Type method");
            }
        }
    
}
        

