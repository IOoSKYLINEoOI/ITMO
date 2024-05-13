using AutoMapper;
using Clinic.Core.Models;
using Clinic.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataAccess.Repositories;

public class EmployeesDepartmentsRepository : IEmployeesDepartmentsRepository
{
    private readonly ClinicDbContext _context;
    private readonly IMapper _mapper;

    public EmployeesDepartmentsRepository(ClinicDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task Add(EmployeeDepartment employeeDepartment)
    {

        var employeeDepartmentEntity = new EmployeeDepartmentEntity()
        {
            EmployeeId = employeeDepartment.EmployeeId,
            DepartmentId = employeeDepartment.DepartmentId,
            Description = employeeDepartment.Description,
            PositionId = employeeDepartment.PositionId,
        };

        await _context.EmployeesDepartments.AddAsync(employeeDepartmentEntity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(
        int employeeId,
        int departmentId,
        string? description,
        int positionId)
    {
        await _context.EmployeesDepartments
            .Where(x => x.EmployeeId == employeeId && x.DepartmentId == departmentId)
            .ExecuteUpdateAsync(s => s
                .SetProperty(s => s.Description, s => description)
                .SetProperty(s => s.PositionId, s => positionId));
    }

    public async Task<EmployeeDepartment> GetById(int employeeId, int departmentId)
    {
        var employeeDepartmentEntity = await _context.EmployeesDepartments
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.EmployeeId == employeeId && u.DepartmentId == departmentId) ?? throw new Exception();

        return _mapper.Map<EmployeeDepartment>(employeeDepartmentEntity);
    }

    public async Task Delete(int employeeId, int departmentId)
    {
        await _context.EmployeesDepartments
            .Where(x => x.EmployeeId == employeeId && x.DepartmentId == departmentId)
            .ExecuteDeleteAsync();
    }
}
