using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IEmployeesDepartmentsRepository
    {
        Task Add(EmployeeDepartment employeeDepartment);
        Task Delete(int employeeId, int departmentId);
        Task<EmployeeDepartment> GetById(int employeeId, int departmentId);
        Task Update(int employeeId, int departmentId, string? description, int positionId);
    }
}