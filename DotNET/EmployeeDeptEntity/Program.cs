using EmployeeDept_CodeFirst.Models;

namespace EmployeeDept_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbServices db = new DbServices();
          
            //1.Display all employee who is in deptId=1
            List<Employee> ls = db.GetEmployee(1);                            
            foreach (Employee i in ls)
            {
                Console.WriteLine(i);
            }

          
            //2.Display all employee 
            db.DisplayAllEmployees();                                        

          
            //3.Enter data in dept. Table 
            Dept dept = new Dept() { DeptName = "OPS" };                     
            db.AddDept(dept);

          
            //4.ADD new Employee
            Employee employee = new Employee()
            {
                Name = "Anup",
                Salary = 50000,
                DeptId = 2
            };
            db.AddEmployee(employee);                                        

          
            //5.Delete employee where Emp ID is 3 
            db.DeleteEmp(3);                                                 

          
            //6. isplay dept. Name and employee within it.
            db.CustomQuery();                                                

          
            //7.Display all employee who's salary is >80k 
            List<Employee> list = db.SalaryLessThan(80000);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //8. Display all employee who s name starting with S.
            /List<Employee> list1 = db.NameStartsWith();                      
            foreach (Employee emp in list1)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
