using Clinic.Application.Interfaces.Auth;
using Clinic.Core.Interfaces.Repositories;
using Clinic.Core.Interfaces.Services;
using Clinic.Core.Models;

namespace Clinic.Application.Services;
public class UserService : IUserService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IJwtProvider _jwtProvider;

    public UserService(
        IUsersRepository usersRepository,
        IPasswordHasher passwordHasher,
        IJwtProvider jwtProvider)
    {
        _usersRepository = usersRepository;
        _passwordHasher = passwordHasher;
        _jwtProvider = jwtProvider;
    }

    public async Task Register(
        string firstName,
        string lastName,
        string fatherName,
        DateOnly dateOfBirth,
        string email,
        string phoneNumber,
        string password)
    {
        var hashedPassword = _passwordHasher.Generate(password);

        var user = User.Create(
            Guid.NewGuid(),
            firstName,
            lastName,
            fatherName,
            dateOfBirth,
            email,
            phoneNumber,
            hashedPassword);

        await _usersRepository.Add(user.Value); ///
    }

    public async Task<string> Login(string email, string password)
    {
        var user = await _usersRepository.GetByEmail(email);

        var result = _passwordHasher.Verify(password, user.PasswordHash);

        if (result == false)
        {
            throw new Exception("Failed to login");
        }

        var token = _jwtProvider.Generate(user);

        return token;
    }
}