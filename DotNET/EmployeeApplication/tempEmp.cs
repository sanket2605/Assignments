using EmployeeUsingEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUsingEvent
{
    internal class tempEmp : Employee
    {

        public tempEmp(string name, double salary) : base(name, salary)
        {
        }
        public override double givebonus()
        {
            netSalary = netSalary + netSalary * 0.5;
            OnBonus(name, netSalary);
            return netSalary;
        }
    }
}


