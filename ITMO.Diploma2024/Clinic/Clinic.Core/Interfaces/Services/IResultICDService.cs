using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IResultICDService
    {
        Task AddResultICD(ResultICD resultICD);
        Task DeleteResultICD(int id);
        Task<List<ResultICD>> GetResultICD(int receptionId);
        Task Update(int id, string iCDCode, string? description, int receptionId);
    }
}