using Models;

namespace BlazorApp_EmployeesNET6.services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);

    }
}
