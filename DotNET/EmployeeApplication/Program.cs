using EmployeeUsingEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUsingEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tempEmp emp1 = new tempEmp("Rohit", 60000);
            permanentEmp emp2 = new permanentEmp("Virat", 80000);

            List<Employee> list = new List<Employee>();
            list.Add(emp1);
            list.Add(emp2);

            foreach(Employee emp in list) 
            {
            emp.Salarydel += (string a, double b) => { Console.WriteLine("SalaryEmail:  Employee Name: {0}   netSalary: {1} ", emp.name, emp.netSalary); };
            emp.Salarydel += delegate (string a, double b) { Console.WriteLine("SalarySMS:    Employee Name: {0}   netSalary: {1} ", emp.name, emp.netSalary);};

            emp.Bonusdel += delegate (string a, double b) { Console.WriteLine("BonusEmail:   Employee Name: {0}   netSalaryAfterBonus: {1}", emp.name, emp.netSalary);};
            emp.Bonusdel += delegate (string a, double b) { Console.WriteLine("BnousSMS:     Employee Name: {0}   netSalaryAfterBnous: {1}", emp.name, emp.netSalary);};
            }
            emp1.givebasic_salary();
            emp1.givebonus();
            Console.WriteLine();
            Console.WriteLine();
            emp2.givebasic_salary();
            emp2.givebonus();
        }
    }
}
