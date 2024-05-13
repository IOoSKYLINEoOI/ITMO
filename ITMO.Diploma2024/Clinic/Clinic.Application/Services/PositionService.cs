using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;
using Microsoft.AspNetCore.Http;

namespace Clinic.Application.Services;

public class PositionService : IPositionService
{
    private readonly IPositionsRepository _positionsRepository;

    public PositionService(IPositionsRepository positionsRepository)
    {
        _positionsRepository = positionsRepository;
    }

    public async Task AddPosition(Position position)
    {
        await _positionsRepository.Add(position);
    }

    public async Task DeletePosition(int id)
    {
        await _positionsRepository.Delete(id);
    }

    public async Task<List<Position>> GetAllPositions()
    {
        return await _positionsRepository.GetAllPositions();
    }

    public async Task Update(int id, string name, string? description)
    {
        await _positionsRepository.Update(id, name, description);
    }
}
