
namespace inheritance_and_polymorphisum_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Stack<int> s = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                if (s.Count > 5)
                {
                    throw new StackException("The stack is full");
                }
                s.Push(i);
            }
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < 11; i++)
            {
                try
                {
                    s.Pop();
                }
                catch (InvalidOperationException e)
                {
                    throw new StackException("The stack is empty");
                }

            }


            Console.ReadKey();
        }
    }
}