using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(int id);

        Employee CreateEmployee(EmployeeDto employeeDto);
    }
}
