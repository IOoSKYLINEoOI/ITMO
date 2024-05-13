using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;

namespace Clinic.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeesRepository _emloyeeRepository;

    public EmployeeService(IEmployeesRepository emloyeeRepository)
    {
        _emloyeeRepository = emloyeeRepository;
    }

    public async Task AddEmployee(Employee employee)
    {
        await _emloyeeRepository.Add(employee);
    }

    public async Task DeleteEmployee(int id)
    {
        await _emloyeeRepository.Delete(id);
    }

    public async Task<List<Employee>> GetAllEmloyee()
    {
        return await _emloyeeRepository.GetAll();
    }

    public async Task UpdateEmployee(int id, DateOnly hiringDate, DateOnly? dateOfDismissal, string? description, Guid userId)
    {
        await _emloyeeRepository.Update(id, hiringDate, dateOfDismissal, description, userId);
    }
}
