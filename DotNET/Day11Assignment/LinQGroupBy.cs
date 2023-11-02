namespace Day11;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public int DeptId { get; set; }
   
}
class Department
{
    public int DeptId { get; set; }
    public string DeptName { get; set; }
   
}

class Temp
{
    public string DeptName { get; set; }
    public string Name { get; set; }

    public Temp(string deptName, string name)
    {

        DeptName = deptName;
        Name = name;
    }
}
class Demo
{ 
    static void Main(string[] args)
    {
        Employee[] employee = new Employee[]
        {new Employee { Id = 1, Name="Rohit", DeptId = 101, Salary=20_000},
         new Employee { Id = 2, Name="Gill",  DeptId = 101, Salary=19_000},
         new Employee { Id = 3, Name="Virat", DeptId = 102, Salary=18_000},
         new Employee { Id = 4, Name="Iyyer", DeptId = 102, Salary=17_000},
         new Employee { Id = 5, Name="Rahul", DeptId = 103, Salary=16_000},
         new Employee { Id = 6, Name="Surya", DeptId = 103, Salary=15_000},
        };

        Department[] dept = new Department[]
        {
            new Department{ DeptId =101,DeptName="ADMIN"},
             new Department{ DeptId =102,DeptName="ADV"},
              new Department{ DeptId =103,DeptName="HR"}
        };

        var subset=from i in employee 
                   join entry in dept
                   on i.DeptId equals entry.DeptId
                   select new Temp(i.Name,entry.DeptName);

        Console.WriteLine("Employee list with their Respective departemnts Using Join");
        foreach (Temp t in subset) Console.WriteLine("DeptName: {0} EmployeeName: {1}",t.DeptName,t.Name);

        var subset2 = from i in employee
                          group i by i.DeptId into g
                          select new { DeptId = g.Key, employees = g };

        foreach (var og in subset2)

        {
            Console.WriteLine(og.DeptId);
            foreach (var i in og.employees)
            {
                Console.WriteLine("{0} \t{1}\t{2}\t", i.Id, i.Name, i.DeptId);
            }

        }

    }
}

