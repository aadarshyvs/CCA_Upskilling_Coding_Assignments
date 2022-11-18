using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Class1
    {
        static void Main(string[] args)
        {
            code c = new code();
            //c.input();
            //Console.WriteLine( c.overload(1, 5));
            //Console.WriteLine( c.overload(6, 5, 4));

            //employee e = new employee();
            //Console.WriteLine("Enter the Employee No");
            //e.EmpNo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Employee Name");
            //e.EmpName = Console.ReadLine();
            //Console.WriteLine("Enter The Salary");
            //e.Salary= Convert.ToInt64(Console.ReadLine());
            //e.SalaryCal();
            //c.prime();
            
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < 100000; i++)
            {
                s.Push(i);
            }
            foreach (var i in s){
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
