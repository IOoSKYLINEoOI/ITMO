using Clinic.Core.Enums;
using Clinic.Core.Models;

namespace Clinic.Core.Interfaces.Repositories;

public interface IUsersRepository
{
    Task Add(User user);
    Task<User> GetByEmail(string email);
    Task<HashSet<Permission>> GetUserPermissions(Guid userId);
}