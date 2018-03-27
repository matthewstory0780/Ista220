using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine($"Journey by Airplane");
            Airplane myplane = new Airplane();
            myplane.StartEngine("Contact");
            myplane.TakeOff();
            myplane.Drive();
            myplane.Land();
            myplane.StopEngine("whiiirrr");

            Console.WriteLine($"journey by Car");
            Car mycar = new Car();
            mycar.StartEngine("BRRRRMMMMM");
            mycar.Accelerate();
            mycar.Drive();
            mycar.brake();
            mycar.StopEngine("phut phut");

            Console.WriteLine("\nTesting Polymorphism");
            Vehicle v = mycar;
            v.Drive();
            v = myplane;
            v.Drive();
 
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
