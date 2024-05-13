namespace Clinic.DataAccess.Models;

public class ImageEntity
{
    public int Id { get; set; }
    public string FileName { get; set; } = string.Empty;

    public UserEntity? User { get; set; }
}
