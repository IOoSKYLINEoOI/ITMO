using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IDepartmentsRepository
    {
        Task Add(Department department);
        Task Delete(int id);
        Task<List<Department>> GetAll();
        Task Update(int id, string name, string? description, int addressId);
    }
}