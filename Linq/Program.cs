using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Employee> Employees=new List<Employee>();
            Employees.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", new DateOnly(1984, 11, 16), new DateOnly(2011, 06, 08), "Mumbai"));
            Employees.Add(new Employee(1002, "Asdin", "Dhalla", "AsstManager", new DateOnly(1984, 08, 20), new DateOnly(2012, 07, 07), "Mumbai"));
            Employees.Add(new Employee(1003, "Madhavi", "Oza", "Consultant", new DateOnly(1987, 11, 14), new DateOnly(2015, 04, 12), "Pune"));
            Employees.Add(new Employee(1004, "Saba", "Shaikh", "SE", new DateOnly(1990, 06, 03), new DateOnly(2016, 02, 02), "Pune"));
            Employees.Add(new Employee(1005, "Nazia", "Shaikh", "SE", new DateOnly(1991, 03, 08), new DateOnly(2016, 02, 02), "Mumbai"));
            Employees.Add(new Employee(1006, "Amit", "Pathak", "Consultant", new DateOnly(1989, 11, 07), new DateOnly(2014, 08, 08), "Chennai"));
            Employees.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant", new DateOnly(1989, 12, 02), new DateOnly(2015, 06, 01), "Mumbai"));
            Employees.Add(new Employee(1008, "Rahul", "Dubey", "Associate", new DateOnly(1993, 11, 11), new DateOnly(2014, 11, 06), "Chennai"));
            Employees.Add(new Employee(1009, "Suresh", "Mistry", "Associate", new DateOnly(1992, 08, 12), new DateOnly(2014, 12, 03), "Chennai"));
            Employees.Add(new Employee(1010, "Sumit", "Shah", "Manager", new DateOnly(1991, 04, 12), new DateOnly(2016, 01, 02), "Pune"));

            foreach(Employee e in Employees)
            {
                Console.WriteLine(e.EmployeeID+" "+e.FirstName+" "+e.LastName+" "+e.Title+" "+e.DOB+" "+e.DOJ+" "+e.City);
            }
            var q3a = from e in Employees
                      select e;
            foreach (var r in q3a)
            {
                Console.WriteLine(JsonConvert.SerializeObject(r));
            }



        }
    }
}