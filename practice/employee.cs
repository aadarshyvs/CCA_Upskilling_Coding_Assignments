using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }
        
        public void SalaryCal()
        {
            if (Salary < 5000)
            {
                HRA = (Salary * 10) / 100;
                TA = Salary * 5 / 100;
                DA = Salary * 15 / 100;
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 15 / 100;
                TA = Salary * 10 / 100;
                DA = Salary * 20 / 100;
            }
            else if(Salary < 15000)
            {
                HRA = Salary * 20 / 100;
                TA = Salary * 15 / 100;
                DA = Salary * 25 / 100;
            }
            else if(Salary < 20000)
            {
                HRA = Salary * 25 / 100;
                TA = Salary * 20 / 100;
                DA = Salary * 30 / 100;
            }
            else if(Salary >= 20000)
            {
                HRA = Salary * 30 / 100;
                TA = Salary * 25 / 100;
                DA = Salary * 35 / 100;
            }
            GrossSalary = Salary+HRA+TA+DA;
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary=GrossSalary-(PF+TDS);


            Console.WriteLine();
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("TA " +TA);
            Console.WriteLine("DA " +DA);
            Console.WriteLine("PF " + PF);
            Console.WriteLine("TDS" +TDS);
            Console.WriteLine("Net Salary "+NetSalary);
            Console.WriteLine("Gross Salary" + GrossSalary);

        }

    }
}
