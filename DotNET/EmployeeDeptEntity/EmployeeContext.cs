using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_CodeFirst.Models
{
    internal class EmployeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=EmployeeDeptEntity;Integrated Security=True;");
        }

        public DbSet<Employee> Employee { get; set; }    //creates table Employee
        public DbSet<Dept> Dept { get; set; }            //creates table Dept
    }
}
