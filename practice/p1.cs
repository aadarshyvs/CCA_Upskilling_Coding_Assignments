using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class p1
    {
        public static int arraysum(int[]Num)
        {
            int sum = 0;
            foreach (int i in Num)
            {
                sum = sum + i;
            }
            return sum;

        }
        public static void Main()
        {
            int[] n = { 1, 2, 3, 4 };

            arraysum(n);
            Console.ReadKey();
        }

    }
}
