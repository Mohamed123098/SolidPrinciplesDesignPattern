using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    abstract internal class Employee
    {
        public string Name { get; set; }
        public int Age  { get; set; }
        public string Address { get; set; }
        protected decimal Bouns { get; set; }
        protected decimal NetSalary { get; set; }
        public override string ToString()
        {

            return $"Name : {Name}\nAge : {Age} \nAddress : {Address} \nNetSalary : {NetSalary}\n==============================";
        }
    }
}
