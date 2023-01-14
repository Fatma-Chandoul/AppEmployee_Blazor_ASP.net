using Models;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp_EmployeesNET6.ViewModels
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required][MinLength(2)][MaxLength(30)]
        public string FirstName { get; set; }
        [Required][MinLength(2)][MaxLength(30)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [EmailAddress][Compare("Email")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int? DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        public Department Department { get; set; } = new Department();
    }
}
