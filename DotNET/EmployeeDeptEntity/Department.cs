using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDept_CodeFirst.Models
{
    internal class Dept
    {
        public int? Id { get; set; }
        public string? DeptName { get; set; }

        [ForeignKey("DeptId")]
        public IList<Employee> Employee { get; set; }
    }
}
