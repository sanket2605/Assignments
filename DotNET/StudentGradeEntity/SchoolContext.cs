using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Models
{
    internal class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=StudentGrade;Integrated Security=True;");
        }

        public DbSet<Student> Student { get; set; }    //creates table Student
        public DbSet<Grade> Grade { get; set; }        //creates table Grade

    }
}
