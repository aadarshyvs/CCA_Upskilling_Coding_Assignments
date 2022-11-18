namespace introduction_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtrc");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("Enter Your Choice ...........");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st number");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int i2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;


            switch (c)
            {
                case 1:
                    {
                        result = i1 + i2;
                        Console.WriteLine("addition of 2 numbers:" + result);
                        break;
                    }
                case 2:
                    {
                        result = i1 - i2;
                        Console.WriteLine("Subraction of 2 numbers:" + result);
                        break;
                    }
                case 3:
                    {
                        result = i1 * i2;
                        Console.WriteLine("multiplication of 2 numbers:" + result);
                        break;
                    }
                case 4:
                    {
                        result = i1 / i2;
                        Console.WriteLine("division of 2 numbers:" + result);
                        break;
                    }

                default:

                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.ReadKey();

        }
    }
}