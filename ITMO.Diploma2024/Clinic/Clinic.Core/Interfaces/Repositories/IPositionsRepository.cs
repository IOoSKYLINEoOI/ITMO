﻿using Clinic.Core.Models;

namespace Clinic.DataAccess.Repositories
{
    public interface IPositionsRepository
    {
        Task Add(Position position);
        Task Delete(int id);
        Task<List<Position>> GetAllPositions();
        Task Update(int id, string name, string? description);
    }
}