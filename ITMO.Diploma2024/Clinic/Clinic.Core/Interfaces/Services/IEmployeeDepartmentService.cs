using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IEmployeeDepartmentService
    {
        Task AddEmployeeDepartment(EmployeeDepartment employeeDepartment);
        Task DeleteEmployeeDepartment(int employeeId, int departmentId);
        Task<EmployeeDepartment> GetByEmployeeDepartment(int employeeId, int departmentId);
        Task UpdateEmployeeDepartment(int employeeId, int departmentId, string? description, int positionId);
    }
}