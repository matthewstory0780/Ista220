using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexcerciseD
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            

            RotateArray(1,2, A);

            void RotateArray(int dir, int place, int[] p)
            {
                int[] result = new int[p.Length];
                for (int i = 0; i < p.Length; i++)
                {
                    int pos = (i + 2) % p.Length;
                    Console.WriteLine(result[i] = p[pos]);
                 }

              

            }

        }
    }
}
