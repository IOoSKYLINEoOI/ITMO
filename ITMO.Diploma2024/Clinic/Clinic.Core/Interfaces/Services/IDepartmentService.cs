using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IDepartmentService
    {
        Task AddDepartment(Department department);
        Task DeleteDepartment(int id);
        Task<List<Department>> GetAllDepartment();
        Task UpdateDepartment(int id, string name, string? description, int addressId);
    }
}