using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FormValidation.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Title { get; set; }
        public enum ETitle { Mr = 1, Mrs = 2, Miss = 3 }

        [Required]
        public string EmployeeFirstName { get; set; }


        [Required]
        public string EmployeeLastName { get; set; }

        //[Required]
        //public string Email { get; set; }


        [Required]
        public double Salary { get; set; }

        [Required]
        public DateTime HireDate { get; set; }


        public byte[] Picture { get; set; }


        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
