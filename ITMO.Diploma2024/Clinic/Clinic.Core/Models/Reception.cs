using CSharpFunctionalExtensions;

namespace Clinic.Core.Models;

public class Reception
{
    public const int MAX_DESCRIPTION_RECEPTION_LENGTH = 250;

    private Reception(
        int id, 
        DateTime dateReceipt, 
        DateTime? dateOfReturn, 
        string? description, 
        Guid userId, 
        int departmentId, 
        int employeeId)
    {
        Id = id;
        DateReceipt = dateReceipt;
        DateOfReturn = dateOfReturn;
        Description = description;
        UserId = userId;
        DepartmentId = departmentId;
        EmployeeId = employeeId;
    }

    public int Id { get; set; }
    public DateTime DateReceipt { get; set; }
    public DateTime? DateOfReturn { get; set; }
    public string? Description { get; set; }
    public Guid UserId { get; set; }
    public int DepartmentId { get; set; }
    public int EmployeeId { get; set; }

    public static Result<Reception> Create(
        int id, 
        DateTime dateReceipt, 
        DateTime? dateOfReturn, 
        string? description, 
        Guid userId, 
        int departmentId, 
        int employeeId)
    {
        if (description.Length > MAX_DESCRIPTION_RECEPTION_LENGTH)
        {
            return Result.Failure<Reception>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_RECEPTION_LENGTH}");
        }

        var reception = new Reception(id, dateReceipt, dateOfReturn, description, userId, departmentId, employeeId);

        return Result.Success(reception);
    }

}
