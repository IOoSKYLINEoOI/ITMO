using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IEmployeeService
    {
        Task AddEmployee(Employee employee);
        Task DeleteEmployee(int id);
        Task<List<Employee>> GetAllEmloyee();
        Task UpdateEmployee(int id, DateOnly hiringDate, DateOnly? dateOfDismissal, string? description, Guid userId);
    }
}