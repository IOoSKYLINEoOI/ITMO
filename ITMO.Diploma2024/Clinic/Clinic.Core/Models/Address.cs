using CSharpFunctionalExtensions;

namespace Clinic.Core.Models;

public class Address
{
    public const int MAX_ADRESS_LENGTH = 60;
    public const int MAX_NUMBER_ADRESS_LENGTH = 99999;
    public const int MAX_DESCRIPTION_ADRESS_LENGTH = 250;

    private Address(
        int id, 
        string country, 
        string region, 
        string city, 
        string street, 
        int houseNumber, 
        int apartmentNumber, 
        string? description, 
        string? pavilion)
    {
        Id = id;
        Country = country;
        Region = region;
        City = city;
        Street = street;
        HouseNumber = houseNumber;
        Pavilion = pavilion;
        ApartmentNumber = apartmentNumber;
        Description = description;
    }

    public int Id { get;}
    public string Country { get;} = string.Empty;
    public string Region { get;} = string.Empty;
    public string City { get;} = string.Empty;
    public string Street { get;} = string.Empty;
    public int HouseNumber { get;}
    public string? Pavilion { get;}
    public int ApartmentNumber { get;}
    public string? Description { get;}

    public static Result<Address> Create(
        int id, 
        string country,
        string region,
        string city,
        string street,
        int houseNumber,
        int apartmentNumber,
        string? description,
        string? pavilion)
    {
        if(string.IsNullOrEmpty(country) || country.Length > MAX_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(country)}' cannot be Null, empty or more than {MAX_ADRESS_LENGTH}");
        }
        if (string.IsNullOrEmpty(region) || region.Length > MAX_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(region)}' cannot be Null, empty or more than {MAX_ADRESS_LENGTH}");
        }
        if (string.IsNullOrEmpty(city) || city.Length > MAX_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(city)}' cannot be Null, empty or more than {MAX_ADRESS_LENGTH}");
        }
        if (string.IsNullOrEmpty(street) || street.Length > MAX_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(street)}' cannot be Null, empty or more than {MAX_ADRESS_LENGTH}");
        }
        if (houseNumber < 0 || houseNumber > MAX_NUMBER_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(houseNumber)}' cannot be <{0} or >{MAX_NUMBER_ADRESS_LENGTH}");
        }
        if (apartmentNumber < 0 || apartmentNumber > MAX_NUMBER_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(apartmentNumber)}' cannot be <{0} or >{MAX_NUMBER_ADRESS_LENGTH}");
        }
        if (description.Length > MAX_DESCRIPTION_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_ADRESS_LENGTH}");
        }
        if (pavilion.Length > MAX_ADRESS_LENGTH)
        {
            return Result.Failure<Address>($"'{nameof(pavilion)}' cannot be more than {MAX_ADRESS_LENGTH}");
        }

        var adress = new Address(
            id,
            country,
            region,
            city,
            street,
            houseNumber,
            apartmentNumber,
            description,
            pavilion);

        return Result.Success(adress);
    }
}
