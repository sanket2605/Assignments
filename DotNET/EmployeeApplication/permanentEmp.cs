
using EmployeeUsingEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AccountUsingEvent
{

    internal class permanentEmp : Employee
    {
        public const double bonus = 0.1;

        public permanentEmp(string name, double salary) : base(name, salary)
        {
        }
        public override double givebonus()
        {
            netSalary = netSalary + netSalary * bonus;
            OnBonus(name, netSalary);
            return netSalary;

        }
    }
}
