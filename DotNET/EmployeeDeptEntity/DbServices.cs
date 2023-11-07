using EmployeeDept_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_CodeFirst
{
    internal class DbServices
    {
        private static readonly EmployeeContext emp = new EmployeeContext();

        public List<Employee> GetEmployee(int id)
        {
            FormattableString sql = $"SELECT * FROM Employee WHERE DeptId ={id} ";
            List<Employee> emplist = emp.Employee.FromSql(sql).ToList<Employee>();
            return emplist;
        }

        public void DisplayAllEmployees()
        {
            foreach (var e in emp.Employee.ToList<Employee>())
            {
                Console.WriteLine(e);
            }
        }

        public void AddDept(Dept dept)
        {
            emp.Add<Dept>(dept);
            emp.SaveChanges();
        }

        public void AddEmployee(Employee e)
        {
            emp.Add<Employee>(e);
            emp.SaveChanges();
        }
       
        public void DeleteEmp(int id)
        {
            Employee employee = emp.Employee.SingleOrDefault<Employee>((emp) => emp.Id == id);
            if (employee != null)
            {
                emp.Remove<Employee>(employee);
                emp.SaveChanges();
            }
            else
            {
                throw new Exception("Given Employee ID not Present");
            }
        }
      
        public void CustomQuery()
        {
            var r = emp.Dept.Join(emp.Employee, (de) => de.Id, (ee) => ee.DeptId, (de, ee) => new { de.DeptName, ee.Name });
            foreach (var item in r)
            {
                Console.WriteLine(item.DeptName + "  " + item.Name);
            }
        }

        public List<Employee> SalaryLessThan(int sal)
        {
            FormattableString sql = $"SELECT * FROM Employee WHERE Salary>{sal}";
            var list = emp.Employee.FromSql(sql).ToList<Employee>();
            return list;
        }

        public List<Employee> NameStartsWith()
        {
            FormattableString sql = $"SELECT * FROM Employee WHERE Name like 'S%'";
            var list = emp.Employee.FromSql(sql).ToList<Employee>();
            return list;
        }  
    }
}

