using CSharpFunctionalExtensions;

namespace Clinic.Core.Models;

public class Department
{
    public const int MAX_DEPARTMENT_LENGTH = 60;
    public const int MAX_DESCRIPTION_DEPARTMENT_LENGTH = 250;

    private Department(int id, string name, string? description, int adressId)
    {
        Id = id;
        Name = name;
        Description = description;
        AddressId = adressId;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int AddressId { get; set; }

    public static Result<Department> Create(int id, string name, string? description, int adressId)
    {
        if (string.IsNullOrEmpty(name) || name.Length > MAX_DEPARTMENT_LENGTH)
        {
            return Result.Failure<Department>($"'{nameof(name)}' cannot be Null, empty or more than {MAX_DEPARTMENT_LENGTH}");
        }
        if (!string.IsNullOrEmpty(description) && description.Length > MAX_DEPARTMENT_LENGTH)
        {
            return Result.Failure<Department>($"'{nameof(description)}' cannot more than {MAX_DESCRIPTION_DEPARTMENT_LENGTH}");
        }

        var department = new Department(id, name, description, adressId);

        return Result.Success(department);
    }
}
