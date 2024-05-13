using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IReceptionService
    {
        Task AddReception(Reception reception);
        Task DeleteReception(int id);
        Task<List<Reception>> GetAllReceptionUser(Guid userId);
        Task Update(int id, DateTime dateReceipt, DateTime? dateOfReturn, string? description, Guid userId, int deprtmentId, int employeeId);
    }
}