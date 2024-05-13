using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Models;
using Clinic.DataAccess.Repositories;

namespace Clinic.Application.Services;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentsRepository _departmentRepository;

    public DepartmentService(IDepartmentsRepository departmentsRepository)
    {
        _departmentRepository = departmentsRepository;
    }

    public async Task AddDepartment(Department department)
    {
        await _departmentRepository.Add(department);
    }

    public async Task<List<Department>> GetAllDepartment()
    {
        return await _departmentRepository.GetAll(); ;
    }

    public async Task UpdateDepartment(
        int id,
        string name,
        string? description,
        int addressId)
    {
        await _departmentRepository.Update(id, name, description, addressId);
    }

    public async Task DeleteDepartment(int id)
    {
        await _departmentRepository.Delete(id);
    }
}
