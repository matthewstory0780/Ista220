using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] i = new int[6] { 0, 2, 4, 6, 8, 10 };
            int size = i.Length;
            int sum = i.Sum();
            double average = (i.Sum() / i.Length);

            for (int j = 0; j < 6; j++) Console.WriteLine("Array A = {0}", i[j]);
            Console.WriteLine($"The sum of the elements in the array is {i.Sum()}");
            Console.WriteLine($"The average of the elements in the array is { (i.Sum()/ i.Length) }");


        }
        
        
        
        


    }

}