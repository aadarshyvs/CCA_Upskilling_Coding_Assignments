namespace inheritance_and_polymorphisum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee employee = new Employee();
            employee.EmployeeDetails();
            Manager manager = new Manager();
            manager.EmployeeDetails();
            MarketingExcutive marketingExcutive = new MarketingExcutive();
            marketingExcutive.EmployeeDetails();



            Console.ReadKey();

        }
    }
}