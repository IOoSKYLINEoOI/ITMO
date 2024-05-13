
namespace Clinic.Core.Interfaces.Services;

public interface IUserService
{
    Task<string> Login(string email, string password);
    Task Register(string firstName, string lastName, string fatherName, DateOnly dateOfBirth, string email, string phoneNumber, string password);
}