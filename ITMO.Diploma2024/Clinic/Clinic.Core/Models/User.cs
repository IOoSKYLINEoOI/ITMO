using CSharpFunctionalExtensions;
using System.Diagnostics.Metrics;

namespace Clinic.Core.Models;

public class User
{
    public const int MAX_EMAIL_LENGTH = 60;
    public const int MAX_USER_NAME_LENGTH = 30;
    public const int USER_PHONENUMBER_LENGTH = 11;
    public const int MAX_DESCRIPTION_USER_LENGTH = 250;
    public static DateOnly MIN_DATE = new DateOnly(1900, 01, 01);
    public static DateOnly MAX_DATE = DateOnly.FromDateTime(DateTime.Now);

    private User(
        Guid id, 
        string firstName, 
        string lastName, 
        string? fatherName, 
        DateOnly dateOfBirth, 
        string email, 
        string phoneNumber,
        string passwordHash)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        DateOfBirth = dateOfBirth;
        Email = email;
        PhoneNumber = phoneNumber;
        PasswordHash = passwordHash;
    }

    public Guid Id { get;}
    public string FirstName { get;} = string.Empty;
    public string LastName { get;} = string.Empty;
    public string? FatherName { get;}
    public DateOnly DateOfBirth { get;}
    public string Email { get;} = string.Empty;
    public string PhoneNumber { get;} = string.Empty;
    public string PasswordHash { get;} = string.Empty;
    public Address? AdressId { get;}
    public Image? ImageId { get;}

    public static Result<User> Create(
        Guid id,
        string firstName,
        string lastName,
        string? fatherName,
        DateOnly dateOfBirth,
        string email,
        string phoneNumber,
        string passwordHash)
    {
        if (string.IsNullOrEmpty(firstName) || firstName.Length > MAX_USER_NAME_LENGTH)
        {
            return ResultICD.Failure<User>($"'{nameof(firstName)}' cannot be Null, empty or more than {MAX_USER_NAME_LENGTH}");
        }
        if (string.IsNullOrEmpty(lastName) || lastName.Length > MAX_USER_NAME_LENGTH)
        {
            return ResultICD.Failure<User>($"'{nameof(lastName)}' cannot be Null, empty or more than {MAX_USER_NAME_LENGTH}");
        }
        if (string.IsNullOrEmpty(fatherName) || fatherName.Length > MAX_USER_NAME_LENGTH)
        {
            return ResultICD.Failure<User>($"'{nameof(fatherName)}' cannot be Null, empty or more than {MAX_USER_NAME_LENGTH}");
        }
        if (dateOfBirth.CompareTo(MAX_DATE) >= 0 || dateOfBirth.CompareTo(MIN_DATE) <= 0)
        {
            return ResultICD.Failure<User>($"'{nameof(dateOfBirth)}'' cannot be < {MAX_DATE} or > {MIN_DATE}");
        }
        if (string.IsNullOrEmpty(email) || email.Length > MAX_EMAIL_LENGTH)
        {
            return ResultICD.Failure<User>($"'{nameof(email)}' cannot be Null, empty or more than {MAX_EMAIL_LENGTH}");
        }
        if (string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length != MAX_EMAIL_LENGTH)
        {
            return ResultICD.Failure<User>($"'{nameof(phoneNumber)}' cannot be Null, empty or > or < than {USER_PHONENUMBER_LENGTH}");
        }
        if (string.IsNullOrEmpty(passwordHash))
        {
            return ResultICD.Failure<User>($"'{nameof(passwordHash)}' cannot be Null or empty");
        }

        var user = new User(
            id,
            firstName,
            lastName,
            fatherName,
            dateOfBirth,
            email,
            phoneNumber,
            passwordHash);

        return ResultICD.Success(user);
    }
}
