using Models;

namespace BlazorApp_EmployeesNET6.services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task<HttpResponseMessage> UpdateEmployee(Employee updatedEmployee);
        Task<HttpResponseMessage> CreateEmployee(Employee NewEmployee);
        Task DeleteEmployee(int id);
    }
}
