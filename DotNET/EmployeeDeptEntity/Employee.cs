using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_CodeFirst.Models
{
    internal class Employee
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }   
        public float? Salary { get; set; }

        [ForeignKey("DeptId")]
        public int? DeptId { get; set; }
    }
}
