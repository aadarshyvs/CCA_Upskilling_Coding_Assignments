namespace introduction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First student marks: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second student marks: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third student marks: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fourth student marks: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Fifth student marks: ");
            int e = Convert.ToInt32(Console.ReadLine());

            var max =(new List<int>() {a,b,c,d,e }).Max();
            Console.WriteLine("Maximum is " + max);
            }
        }
    }
