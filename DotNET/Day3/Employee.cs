/*Create class Employee with private vatiable id name salary, netsalary
Create method public double Calculatesal()
Which will return net salary. Netsalary= salary-salary*10%
Create method display which will display Name and net salary.
Create 3 object of a class and call display method*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Employee
    {
       private int id;
       private string name;
       private double salary;
       private double netsalary;
        
        public Employee(String name,int salary)
        {
            this.name = name;
            this.salary = salary;
           
        }

        public double CalculateSal()
        {
            netsalary = salary - salary * 0.1;
            return netsalary;
        }
        public void display()
        {
            Console.WriteLine("Employee Name: "+name+"\t"+netsalary);
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Sanket",48000);
            emp1.CalculateSal();
            emp1.display();
            Console.WriteLine();

            Employee emp2 = new Employee("Rohit", 50000);
            emp2.CalculateSal();
            emp2.display();
            Console.WriteLine();

            Employee emp3 = new Employee("Vedant", 52000);
            emp3.CalculateSal();
            emp3.display();
            Console.WriteLine();
        }
    }
    
}
