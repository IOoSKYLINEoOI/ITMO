using CSharpFunctionalExtensions;
using System.Diagnostics.Metrics;

namespace Clinic.Core.Models;

public class Employee
{
    public const int MAX_DESCRIPTION_EMPLOYEE_LENGTH = 250;
    public static DateOnly DATE_NOW = DateOnly.FromDateTime(DateTime.Now);

    private Employee(int id, DateOnly hiringDate, DateOnly? dateOfDismissal, string? description, Guid userId)
    {
        Id = id;
        HiringDate = hiringDate;
        DateOfDismissal = dateOfDismissal;
        Description = description;
        UserId = userId;
    }

    public int Id { get; set; }
    public DateOnly HiringDate { get; set; }
    public DateOnly? DateOfDismissal { get; set; }
    public string? Description { get; set; }
    public Guid UserId { get; set; }

    public static Result<Employee> Create(int id, DateOnly hiringDate, DateOnly? dateOfDismissal, string? description, Guid userId)
    {
        if (hiringDate.CompareTo(DATE_NOW) <= 0)
        {
            return Result.Failure<Employee>($"'{nameof(hiringDate)}'' cannot be > {DATE_NOW}");
        }
        if (description.Length > MAX_DESCRIPTION_EMPLOYEE_LENGTH)
        {
            return Result.Failure<Employee>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_EMPLOYEE_LENGTH}");
        }

        var employee = new Employee(id, hiringDate, dateOfDismissal, description, userId);

        return Result.Success(employee);
    }

}
