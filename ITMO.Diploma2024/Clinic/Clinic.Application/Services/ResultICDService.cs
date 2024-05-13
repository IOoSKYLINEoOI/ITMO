using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;

namespace Clinic.Application.Services;

public class ResultICDService : IResultICDService
{
    private readonly IResultsICDRepository _resultsICDRepository;

    public async Task AddResultICD(ResultICD resultICD)
    {
        await _resultsICDRepository.Add(resultICD);
    }

    public async Task DeleteResultICD(int id)
    {
        await _resultsICDRepository.Delete(id);
    }

    public async Task<List<ResultICD>> GetResultICD(int receptionId)
    {
        return await _resultsICDRepository.Get(receptionId);
    }

    public async Task Update(int id, string iCDCode, string? description, int receptionId)
    {
        await Update(id, iCDCode, description, receptionId);
    }
}
