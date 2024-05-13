using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;

namespace Clinic.Application.Services;

public class ReceptionService : IReceptionService
{
    private readonly IReceptionsRepository _receptionsRepository;

    public ReceptionService(IReceptionsRepository receptionsRepository)
    {
        _receptionsRepository = receptionsRepository;
    }

    public async Task AddReception(Reception reception)
    {
        await _receptionsRepository.Add(reception);
    }

    public async Task DeleteReception(int id)
    {
        await _receptionsRepository.Delete(id);
    }

    public async Task<List<Reception>> GetAllReceptionUser(Guid userId)
    {
        return await _receptionsRepository.GetAll(userId);
    }

    public async Task Update(int id, DateTime dateReceipt, DateTime? dateOfReturn, string? description, Guid userId, int deprtmentId, int employeeId)
    {
        await _receptionsRepository.Update(id, dateReceipt, dateOfReturn, description, userId, deprtmentId, employeeId);
    }
}
