using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excersise4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {  1, 3, 5, 7, 9 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i].ToString());
            }

        }


    }
}
