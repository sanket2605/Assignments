/*Create class Employee having member Id, Name, Salary, NetSalary, Dept d
Create enum Dept {MKT, ADMIN, ADV}
Create method public double paytax(double p) {return tax amount and set 
netsalary(note: netsalary=salary-salary*p%)}
Create method display to display name and netsalary and department
When you load application it should print name of company.
new Employee(1,”Raj”,50000,Dept.MKT)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Dept
    {
        MKT,
        ADMIN,
        ADV
    }
    internal class Employee
    {
        static int getid;
        int id;
        string name;
        double salary;
        double netSalary;
        Dept d;
        const double roi = 0.07;

        static Employee()
        {
            Console.WriteLine("Bhoopesh & co");
        }
        Employee(String name,double salary,Dept d)
        {
            id = ++id;
            this.name = name;
            this.salary = salary;
            this.d = d;

        }
        public double paytax(double roi)
        {
            netSalary = salary - salary * roi;
            return netSalary;
        }
        public void display(Employee obj)
        {
            Console.WriteLine("Employee name: " + name +"\t"+"netSalary is "+netSalary+"\t"+"Dept is "+d);
        }

        static void Main(string[] args)
        {
            Employee e1=new Employee("Rohit",52000,Dept.MKT);
            e1.paytax(roi);
            e1.display(e1);
            Employee e2 = new Employee("Vedant", 48000, Dept.ADMIN);
            e2.paytax(roi);
            e2.display(e2);
            Employee e3 = new Employee("Anup", 44000, Dept.ADV);
            e3.paytax(roi);
            e3.display(e3);


        }
     
    }
    
}
