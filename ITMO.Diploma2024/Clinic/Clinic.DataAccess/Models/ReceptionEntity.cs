namespace Clinic.DataAccess.Models;

public class ReceptionEntity
{
    public int Id { get; set; }
    public DateTime DateReceipt { get; set; }
    public DateTime? DateOfReturn { get; set; }
    public string? Description { get; set; }

    public Guid UserId { get; set; }
    public UserEntity? User { get; set; }

    public int DepartmentId {  get; set; }
    public DepartmentEntity? Department { get; set; }

    public int EmployeeId { get; set; }
    public EmployeeEntity? Employee { get; set; }

    public ICollection<ResultICDEntity> Result { get; set; } = [];
}
