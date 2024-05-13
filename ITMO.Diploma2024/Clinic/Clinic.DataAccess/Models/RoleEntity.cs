namespace Clinic.DataAccess.Models;

public class RoleEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<PermissionEntity> Permissions { get; set; } = [];

    public ICollection<UserEntity> Users { get; set; } = [];
}
