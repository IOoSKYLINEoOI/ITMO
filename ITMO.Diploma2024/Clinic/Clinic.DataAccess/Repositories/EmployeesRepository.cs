using AutoMapper;
using Clinic.Core.Models;
using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Repositories;

public class EmployeesRepository : IEmployeesRepository
{
    private readonly ClinicDbContext _context;

    public EmployeesRepository(ClinicDbContext context)
    {
        _context = context;
    }

    public async Task Add(Employee employee)
    {

        var employeeEntity = new EmployeeEntity()
        {
            Id = employee.Id,
            HiringDate = employee.HiringDate,
            DateOfDismissal = employee.DateOfDismissal,
            UserId = employee.UserId,
            Description = employee.Description
        };

        await _context.Employees.AddAsync(employeeEntity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(
        int id,
        DateOnly hiringDate,
        DateOnly? dateOfDismissal,
        string? description,
        Guid userId)
    {
        await _context.Employees
            .Where(x => x.Id == id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(s => s.HiringDate, s => hiringDate)
                .SetProperty(s => s.DateOfDismissal, s => dateOfDismissal)
                .SetProperty(s => s.Description, s => description)
                .SetProperty(s => s.UserId, s => userId));
    }

    public async Task<List<Employee>> GetAll()
    {
        var employeeEntity = await _context.Employees
            .AsNoTracking()
            .ToListAsync();

        var employees = employeeEntity
            .Select(b => Employee.Create(b.Id, b.HiringDate, b.DateOfDismissal, b.Description, b.UserId).Value)
            .ToList();

        return employees;
    }

    public async Task Delete(int id)
    {
        await _context.Employees
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
    }
}
