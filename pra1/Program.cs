namespace introduction_3
{
    public class Program
    {
        public static void arraysum(int[] Num)
        {
            int sum = 0;
            foreach (int i in Num)
            {
                sum = sum + i;
            }

            Console.WriteLine(sum);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] n = { 1, 2, 3, 4 };

            arraysum(n);
            Console.ReadKey();
        }
    }
}