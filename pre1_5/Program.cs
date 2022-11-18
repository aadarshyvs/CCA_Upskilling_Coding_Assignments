namespace introduction_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            float r = 9;
            Program p = new Program();
            (float a, float c) = p.AreaAndCircumference(r);
            Console.WriteLine("Area = " + a + " Circumference = " + c);
            Console.ReadKey();
        }
        public (float, float) AreaAndCircumference(float radius)
        {
            float area = (float)(3.14 * radius * radius);
            float circumference = (float)(2 * 3.14 * radius);

            return (area, circumference);
        }
    }
}