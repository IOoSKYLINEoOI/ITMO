using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;

namespace Clinic.Application.Services;

public class EmployeeDepartmentService : IEmployeeDepartmentService
{
    private readonly IEmployeesDepartmentsRepository _employeesDepartmentsRepository;

    public EmployeeDepartmentService(IEmployeesDepartmentsRepository employeesDepartmentsRepository)
    {
        _employeesDepartmentsRepository = employeesDepartmentsRepository;
    }

    public async Task AddEmployeeDepartment(EmployeeDepartment employeeDepartment)
    {
        await _employeesDepartmentsRepository.Add(employeeDepartment);
    }

    public async Task DeleteEmployeeDepartment(int employeeId, int departmentId)
    {
        await _employeesDepartmentsRepository.Delete(employeeId, departmentId);
    }

    public async Task<EmployeeDepartment> GetByEmployeeDepartment(int employeeId, int departmentId)
    {
        return await _employeesDepartmentsRepository.GetById(employeeId, departmentId);
    }

    public async Task UpdateEmployeeDepartment(int employeeId, int departmentId, string? description, int positionId)
    {
        await _employeesDepartmentsRepository.Update(employeeId, departmentId, description, positionId);
    }
}
