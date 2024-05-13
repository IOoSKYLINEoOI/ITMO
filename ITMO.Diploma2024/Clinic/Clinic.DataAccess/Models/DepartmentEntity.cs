namespace Clinic.DataAccess.Models;

public class DepartmentEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public int AddressId {  get; set; }
    public AddressEntity? Adress { get; set; }

    public ICollection<EmployeeEntity> Employee { get; set; } = [];
    public ICollection<ReceptionEntity> Reception { get; set; } = [];
}
