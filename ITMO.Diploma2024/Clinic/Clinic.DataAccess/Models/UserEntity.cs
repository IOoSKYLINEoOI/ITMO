namespace Clinic.DataAccess.Models;

public class UserEntity
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? FatherName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Email { get; set; }= string.Empty;
    public string PhoneNumber { get; set; }= string.Empty;
    public string PasswordHash { get; set; } = string.Empty;

    public ICollection<RoleEntity> Roles { get; set; } = [];
    public ICollection<ReceptionEntity> Reception { get; set; } = [];
    public int AdressId { get; set; }
    public AddressEntity? Adress { get; set; }

    public int ImageId { get; set; }
    public ImageEntity? Image { get; set; }

    public EmployeeEntity? Employee { get; set; }
}
