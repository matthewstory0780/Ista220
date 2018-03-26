
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Week3GradedExercise

{

    class Animals

    {

        public string name;
        private readonly object Sound;

        public Animals(string n)

        {

            this.name = n;

        }

        public void Sound()

        {

            Console.WriteLine($"My name is {this.name}, I'm a {GetType().Name}. I say "{Sound}".");

            

        }

        public void Eat(Food food)

        {

            if (food.available > 0)

            {

                --food.available;

                Console.WriteLine($"{this.name} the {GetType().Name} ate, and now there is {food.available} lbs of {food.name} available to eat.");

            }

            else Console.WriteLine($"There was no {food.name} for {this.name} the {GetType().Name} to eat.");
}




    namespace Farm

    {


            class Cat : Animals

            {

                public Cat(string n) : base(n)

                {

                    this.name = n;

                }

                public override string Sound()

                {

                    return "meow";

                }

                      

                class Cow : Animals

                {

                    public Cow(string n) : base(n)

                    {

                        this.name = n;

                    }

                public override string Sound()

                    {

                        return "moo";

                    }

                   
                }

            }


        

            class Horse : Animals

            {

                public Horse(string n) : base(n)

                {

                    this.name = n;

                }

                public override string Sound()

                {

                    return "neigh";

                }
            class Pig : Animals

            {

                public Pig(string n) : base(n)

                {

                    this.name = n;

                }

                public override string Sound()

                {

                    return "oink";

                }


            }

        }








    }

    }








