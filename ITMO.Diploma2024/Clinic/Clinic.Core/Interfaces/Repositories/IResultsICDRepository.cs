using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IResultsICDRepository
    {
        Task Add(ResultICD resultICD);
        Task Delete(int id);
        Task<List<ResultICD>> Get(int receptionId);
        Task Update(int id, string iCDCode, string? description, int receptionId);
    }
}