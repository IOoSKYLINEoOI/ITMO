using CSharpFunctionalExtensions;

namespace Clinic.Core.Models;

public class Position
{
    public const int MAX_POSITION_LENGTH = 60;
    public const int MAX_DESCRIPTION_POSITION_LENGTH = 250;

    private Position(int id, string name, string? description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public static Result<Position> Create(int id, string name, string? description)
    {
        if (string.IsNullOrEmpty(name) || name.Length > MAX_POSITION_LENGTH)
        {
            return Result.Failure<Position>($"'{nameof(name)}' cannot be Null, empty or more than {MAX_POSITION_LENGTH}");
        }
        if (description.Length > MAX_DESCRIPTION_POSITION_LENGTH)
        {
            return Result.Failure<Position>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_POSITION_LENGTH}");
        }

        var position = new Position(id, name, description);

        return Result.Success(position);
    }
}
