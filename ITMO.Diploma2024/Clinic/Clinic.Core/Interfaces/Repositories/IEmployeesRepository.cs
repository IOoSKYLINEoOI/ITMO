using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IEmployeesRepository
    {
        Task Add(Employee employee);
        Task Delete(int id);
        Task<List<Employee>> GetAll();
        Task Update(int id, DateOnly hiringDate, DateOnly? dateOfDismissal, string? description, Guid userId);
    }
}