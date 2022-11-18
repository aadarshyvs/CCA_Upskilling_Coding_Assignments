using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class code
    {
        public void input()
        {
            string[] arr = new string[10];
            int i;
            Console.WriteLine("Input 10 Elements");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();

            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public int overload(int a, int b)
        {
            return (a + b);
        }
        public int overload(int a ,int b, int c)
        {
            return (a + b + c);
        }
        public void prime()
        {
            Console.WriteLine("Enter a Number");
            int num =Convert.ToInt32( Console.ReadLine());
            bool loop = true;
            for(int i = 2; i < num; i++)
            {
                if (num%i== 0)
                {
                    loop = false;
                }
            }
            if (loop)
            {
                Console.WriteLine("number is prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
