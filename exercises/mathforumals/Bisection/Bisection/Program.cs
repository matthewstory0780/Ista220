using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace bisection

{

    class Program

    {

        static void Main(string[] args)

        {

            string input;

            while (true)

            {

                try

                {

                    Console.Write("Guess a number between 1 and 10");

                    input = Console.ReadLine();
                    int arr[1,2,3,4,5,6,7,8,9,10] = new int arr[];

                    if (input == "")

                    {

                        Console.WriteLine("you chose the wrong number");

                    }

                    else if (int.Parse(input) == 1)

                    {

                        HumanGuess.Run();

                        break;

                    }

                    else if (int.Parse(input) == 2)

                    {

                        ComputerGuess.Run();

                        break;

                    }

                    else if (int.Parse(input) == 3)

                    {

                        ComputerGuess2.Run();

                        break;

                    }

                    else Console.WriteLine("Your value was out of range.\n");

                }

                catch (Exception)

                {

                    Console.WriteLine("Please enter only a whole number (no letters or special characters).\n");

                }

            }

        }

    }

}
