namespace Clinic.DataAccess.Models;

public class EmployeeEntity
{
    public int Id { get; set; }
    public DateOnly HiringDate { get; set; }
    public DateOnly? DateOfDismissal {  get; set; }
    public string? Description {  get; set; }

    public Guid UserId { get; set; }
    public UserEntity? User { get; set; }

    public ICollection<DepartmentEntity> Department { get; set; } = [];
    public ICollection<ReceptionEntity> Reception { get; set; } = [];
}
