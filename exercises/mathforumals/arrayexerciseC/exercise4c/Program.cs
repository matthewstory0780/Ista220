using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 3, 5, 7, 9 };
            int len = A.Length; //self explanatory 
            int tmp = A[len - 1]; //save last element value
            for (int i = len - 1; i > 0; i--) //starting from the end to begining
            {
                A[i] = A[i - 1]; //assign value of the previous element
            }
            A[0] = tmp; //now "rotate" last to first.
            Console.WriteLine(A[0] = tmp);

        }
    }
}
