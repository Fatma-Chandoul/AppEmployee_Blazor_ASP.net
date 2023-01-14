using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        [Required][MinLength(2)][MaxLength(30)]
        public string FirstName { get; set; }
        [Required][MinLength(2)][MaxLength(30)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }
    }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
}
