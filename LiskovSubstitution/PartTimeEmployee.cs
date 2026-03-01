using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class PartTimeEmployee : Employee, ISalaryCalculator

    {
        public PartTimeEmployee(decimal hourRateCalculation)
        {
            HourRateCalculation = hourRateCalculation;
            Bouns = 20 * HourRateCalculation;
            NetSalary = CalculateSalary();
        }
        private int WorkingHours { get; set; }
        public decimal HourRateCalculation { get; set; }
        public decimal CalculateSalary()
              => WorkingHours * HourRateCalculation + Bouns;

    }
}
