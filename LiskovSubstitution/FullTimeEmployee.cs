using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class FullTimeEmployee:Employee,ISalaryCalculator
    {
        public FullTimeEmployee(decimal Salary)
        {
            Bouns = 1500;
            this.Salary = Salary;
            NetSalary = CalculateSalary();
        }
        public decimal Salary { get; set; }
        public decimal CalculateSalary()
             => Salary + Bouns;
    }
}
