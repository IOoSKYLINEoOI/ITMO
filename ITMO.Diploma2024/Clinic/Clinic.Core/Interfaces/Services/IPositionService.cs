using Clinic.Core.Models;

namespace Clinic.Application.Services
{
    public interface IPositionService
    {
        Task AddPosition(Position position);
        Task DeletePosition(int id);
        Task<List<Position>> GetAllPositions();
        Task Update(int id, string name, string? description);
    }
}