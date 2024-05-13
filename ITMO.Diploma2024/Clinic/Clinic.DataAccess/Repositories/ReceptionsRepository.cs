using AutoMapper;
using Clinic.Core.Models;
using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Repositories;

public class ReceptionsRepository : IReceptionsRepository
{
    private readonly ClinicDbContext _context;

    public ReceptionsRepository(ClinicDbContext context)
    {
        _context = context;
    }

    public async Task Add(Reception reception)
    {

        var receptionEntity = new ReceptionEntity()
        {
            Id = reception.Id,
            DateReceipt = reception.DateReceipt,
            DateOfReturn = reception.DateOfReturn,
            Description = reception.Description,
            UserId = reception.UserId,
            DepartmentId = reception.DepartmentId,
            EmployeeId = reception.EmployeeId,
        };

        await _context.Receptions.AddAsync(receptionEntity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(
        int id,
        DateTime dateReceipt,
        DateTime? dateOfReturn,
        string? description,
        Guid userId,
        int deprtmentId,
        int employeeId)
    {
        await _context.Receptions
            .Where(x => x.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(s => s.DateReceipt, s => dateReceipt)
                .SetProperty(s => s.DateOfReturn, s => dateOfReturn)
                .SetProperty(s => s.Description, s => description)
                .SetProperty(s => s.UserId, s => userId)
                .SetProperty(s => s.DepartmentId, s => deprtmentId)
                .SetProperty(s => s.EmployeeId, s => employeeId));
    }

    public async Task<List<Reception>> GetAll(Guid userId)
    {
        var receptionEntity = await _context.Receptions
            .Where(x => x.UserId == userId)
            .AsNoTracking()
            .ToListAsync();

        var receptions = receptionEntity
            .Select(b => Reception.Create(b.Id, b.DateReceipt, b.DateOfReturn, b.Description, b.UserId, b.DepartmentId, b.EmployeeId).Value)
            .ToList();

        return receptions;
    }

    public async Task Delete(int id)
    {
        await _context.Receptions
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
    }
}
