using CSharpFunctionalExtensions;

namespace Clinic.Core.Models;

public class EmployeeDepartment
{
    public const int MAX_DESCRIPTION_EMPLOYEEDEPARTMENT_LENGTH = 250;

    private EmployeeDepartment(int employeeId, int departmentId, string? description, int positionId)
    {
        EmployeeId = employeeId;
        DepartmentId = departmentId;
        Description = description;
        PositionId = positionId;
    }

    public int EmployeeId { get; set; }
    public int DepartmentId { get; set; }
    public string? Description { get; set; }
    public int PositionId { get; set; }

    public static Result<EmployeeDepartment> Create(int employeeId, int departmentId, string? description, int positionId)
    {
        if (description.Length > MAX_DESCRIPTION_EMPLOYEEDEPARTMENT_LENGTH)
        {
            return Result.Failure<EmployeeDepartment>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_EMPLOYEEDEPARTMENT_LENGTH}");
        }

        var employeeDepartment = new EmployeeDepartment(employeeId, departmentId, description, positionId);

        return Result.Success(employeeDepartment);
    }
}
