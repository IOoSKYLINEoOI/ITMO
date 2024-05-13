namespace Clinic.DataAccess.Models;

public class EmployeeDepartmentEntity
{
    public int EmployeeId { get; set; }
    public int DepartmentId { get; set; }
    public string? Description { get; set; }

    public int PositionId {  get; set; }
    public PositionEntity? Position { get; set; }
}
