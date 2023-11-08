using AccountUsingEvent;
using System.Security.Principal;

namespace EmployeeUsingEvent;

public delegate void Mydel(string b, double c);
public abstract class Employee
{
    public Mydel Salarydel, Bonusdel;
    public  int id;
    public static int getid;
    public string name;
    public double salary;
    public double netSalary;
    public const double maxSalary = 1_50_000;
    public const double tds = 0.1;

    static Employee()
    {
        Console.WriteLine(" Atom & Co. ");
    }

    public string Name { set { name=value; } get { return name; } }
    public double Salary { protected set { salary = value; } get { return salary; } }

    public Employee(string name, double salary)
    {
        id = ++getid;
        Name = name;
        if (salary > maxSalary)
            throw new Exception("netSalary cannot be greater than Limit");
        else
            Salary = salary;
    }

    public double givebasic_salary()
    {
        netSalary = salary - (salary * tds);
         OnSalary(name, netSalary);
        return netSalary;
    }
    public abstract double givebonus();

    public void OnSalary(string name, double netSalary)
    {
        if (Salarydel != null)
#pragma warning disable IDE1005 // Delegate invocation can be simplified.
            Salarydel(name, netSalary);
#pragma warning restore IDE1005 // Delegate invocation can be simplified.
    }
    public void OnBonus(string name, double netSalary)
    {
        if (Bonusdel != null)
            Bonusdel(name, netSalary);
    }
}
