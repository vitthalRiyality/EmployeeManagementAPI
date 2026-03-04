using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repositories;

namespace EmployeeManagementAPI.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public List<Employee> GetEmployees()
        {
            return _repository.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            return _repository.GetById(id);
        }

        public Employee CreateEmployee(EmployeeDto employeeDto)
        {
            var employee = new Employee
            {
                Name = employeeDto.Name,
                Department = employeeDto.Department,
                Salary = employeeDto.Salary
            };

            return _repository.Add(employee);
        }
    }
}
