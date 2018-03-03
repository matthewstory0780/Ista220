using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace excersise2b
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
               Console.WriteLine("Enter test score one");
               double one;
               one = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("Enter test score two: ");
                double two;
                two = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score 'three': ");
                double three;
                three = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score four: ");
                double four;
                four = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score five: ");
                double five;
                five = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score six: ");
                double six;
                six = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score seven: ");
                double seven;
                seven = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score eight: ");
                double eight;
                eight = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score nine: ");
                double nine;
                nine = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter test score ten: ");
                double ten;
                ten = Convert.ToDouble(Console.ReadLine());

            double total = 10;
            double sum = (one + two + three + four + five + six + seven + eight + nine + ten);
            double average = total/sum;
            string grade;
            if (average <= 90)
                grade = "A";
            else if (average >= 80)
                grade = "B";
            else if (average >= 70)
                grade = "C";
            else if (average >= 60)
                grade = "D";
            else
            grade = "F";




            Console.WriteLine($"Your grade is: {grade} ");

           
                

            
            }
        }




    }
        
    
        
