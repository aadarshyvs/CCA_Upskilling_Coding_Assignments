namespace introduction_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            int a = 5, b = 7;
            (a, b) = p.Swapnumbers(a, b);
            Console.WriteLine("a = " + a + " b = " + b);
        }
        public (int, int) Swapnumbers(int a, int b)
        {
            return (b, a);
        }
    }
}