using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Employee
    {
        public Employee(int eid,string fname,string lname,string title,DateOnly dob,DateOnly doj,string city)
        {
            EmployeeID= eid;
            FirstName= fname;
            LastName= lname;
            Title= title;
            DOB= dob;
            DOJ = doj;
            City = city;

        }

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateOnly DOB { get; set; }
        public DateOnly DOJ { get; set; }
        public string City { get; set; }
        

        

    }
}
