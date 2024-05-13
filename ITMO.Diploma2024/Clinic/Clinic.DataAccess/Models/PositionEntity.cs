namespace Clinic.DataAccess.Models;

public class PositionEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description {  get; set; }

    public ICollection<EmployeeDepartmentEntity> EmployeeDepartment { get; set; } = [];
}
