using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IReceptionsRepository
    {
        Task Add(Reception reception);
        Task Delete(int id);
        Task<List<Reception>> GetAll(Guid userId);
        Task Update(int id, DateTime dateReceipt, DateTime? dateOfReturn, string? description, Guid userId, int deprtmentId, int employeeId);
    }
}