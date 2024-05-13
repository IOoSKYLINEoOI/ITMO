namespace Clinic.DataAccess.Models;

public class ResultICDEntity
{
    public int Id { get; set; }
    public string ICDCode { get; set; } = string.Empty;
    public string? Description { get; set; }

    public int ReceptionId { get; set; }
    public ReceptionEntity? Reception { get; set; }
}
