using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation.Models
{
    public class Department
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
